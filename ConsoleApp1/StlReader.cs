using System;
using System.IO;

namespace ConsoleApp1
{
    struct StlSize
    {
        public double X;
        public double Y;
        public double Z;
    }
    struct StlVertex
    {
        public float X;
        public float Y;
        public float Z;
    }

    class StlTriangle
    {
        public StlVertex Vector;
        public StlVertex A, B, C;
    }

    class StlReader
    {
        public StlSize Dimension;

        public bool Parse(string file)
        {
            try
            {
                using (BinaryReader f = new BinaryReader(File.OpenRead(file)))
                {
                    byte[] header = new byte[80];
                    f.Read(header, 0, header.Length);

                    UInt32 tCount = f.ReadUInt32();
                    for (uint i = 0; i < tCount; i++)
                    {
                        f.Read()
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error parsing file - " + e.Message);
                return false;
            }

            return true;
        }

        private StlVertex ReadVertex(BinaryReader b)
        {
            StlVertex s;

            s

            return s;
        }

        private StlTriangle ReadTriangle(BinaryReader b)
        {
            //A = b.ReadSingle();
            // B = b.ReadSingle();
            // C = b.ReadSingle();
        }
    }
}
