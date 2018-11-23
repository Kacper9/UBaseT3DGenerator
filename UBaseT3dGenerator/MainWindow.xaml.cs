using System;
using System.Windows;
using System.Windows.Forms;

namespace UBaseT3dGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void generateButton_Click(object sender, RoutedEventArgs e)
        {
            T3DFile t3dFile = new T3DFile();
            t3dFile.generateFile(uBaseSizeBox.Text, (int)fileAmount.Value, destinationFOlderPathBox.Text, filePrefix.Text, photoRelativePathBox.Text, photoFormatBox.Text);
            System.Windows.MessageBox.Show("Pliki stworzone!");
        }

        private void SetDestinationFOlderPathButton_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                destinationFOlderPathBox.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
