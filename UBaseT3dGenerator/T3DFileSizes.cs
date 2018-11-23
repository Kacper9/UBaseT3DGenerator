using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBaseT3dGenerator
{
    class T3DFileSizes
    {
        public string size1000m { get; } =
        @"//----------------
        Parent: none
        Type: Mesh
        Name: Plane
        Anim: false
        Ambient: 255.0 255.0 255.0
        Diffuse: 204.0 204.0 204.0
        Specular: 255.0 255.0 255.0
        SelfIllum: false
        Wire: false
        WireSize: 1.0
        Opacity: 100.0
        Map: number.format
        MaxDistance: 1000
        MinDistance: 0
        Transform:
            500.000000 0.000000 0.000000 0.000000
            0.000000 500.000000 0.000000 0.000000
            0.000000 0.000000 1.000000 0.000000
            0.000000 0.000000 0.000000 1.000000
        NumVerts: 6
        0
        1.000000 -1.000000 0.000000 1.000665 0.000079 
        -1.000000 1.000000 0.000000 0.000079 0.999921 
        -1.000000 -1.000000 0.000000 0.000079 0.000079 
        
        0
        1.000000 -1.000000 0.000000 1.000665 0.000079 
        1.000000 1.000000 0.000000 1.003311 0.999921 
        -1.000000 1.000000 0.000000 0.000079 0.999921";
        public string size100m { get; } =
        @"//----------------
        Parent: none
        Type: Mesh
        Name: Plane
        Anim: false
        Ambient: 255.0 255.0 255.0
        Diffuse: 204.0 204.0 204.0
        Specular: 255.0 255.0 255.0
        SelfIllum: false
        Wire: false
        WireSize: 1.0
        Opacity: 100.0
        Map: number.format
        MaxDistance: 1000
        MinDistance: 0
        Transform:
            50.000000 0.000000 0.000000 0.000000
            0.000000 50.000000 0.000000 0.000000
            0.000000 0.000000 1.000000 0.000000
            0.000000 0.000000 0.000000 1.000000
        NumVerts: 6
        0
        1.000000 -1.000000 0.000000 1.000665 0.000079 
        -1.000000 1.000000 0.000000 0.000079 0.999921 
        -1.000000 -1.000000 0.000000 0.000079 0.000079 
        
        0
        1.000000 -1.000000 0.000000 1.000665 0.000079 
        1.000000 1.000000 0.000000 1.003311 0.999921 
        -1.000000 1.000000 0.000000 0.000079 0.999921";
    }
}
