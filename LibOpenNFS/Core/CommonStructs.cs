﻿using System.Runtime.InteropServices;

namespace LibOpenNFS.Core
{
    public static class CommonStructs
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct Point3D
        {
            public readonly float X;
            
            public readonly float Y;
            
            public readonly float Z;
            
            public readonly float W;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct Matrix
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public readonly float[] Data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct JDLZHeader
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            private readonly char[] Marker;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            private readonly byte[] misc;

            public readonly uint UncompressedLength;
            
            public readonly uint CompressedLength;
        }
    }
}