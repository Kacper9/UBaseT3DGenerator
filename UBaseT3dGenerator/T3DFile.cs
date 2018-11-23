using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBaseT3dGenerator
{
    class T3DFile
    {


        public void generateFile(string fileSize, int fileAmount, string filePath, string prefix, string photoPath, string photoFormat)
        {
            var FileSizes = new T3DFileSizes();
            string fileContent = "";
            switch(fileSize)
            {
                case "100m":
                    fileContent = FileSizes.size100m;
                    break;

                case "1000m":
                    fileContent = FileSizes.size1000m;
                    break;
            }

            if(!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            for(int i = 1; i <= fileAmount; i++)
            {
                StringBuilder sbFIleContent = new StringBuilder(fileContent);
                StringBuilder sbPhotoPath = new StringBuilder(photoPath);
                string photoPathCalculated = sbPhotoPath.Replace("{id}", i.ToString()).ToString();
                string fileContentCalculated = sbFIleContent.Replace("number.format", photoPathCalculated + "." + photoFormat).ToString();
                File.WriteAllText(filePath + "/" + prefix + i + ".t3d", fileContentCalculated);
            }
        }
    }
}
