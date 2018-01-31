using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace SerializationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //serialize();

            deserialize();
        }

        private static void serialize()
        {
            Rectangle rect1 = new Rectangle(20, 10, BorderStyle.DOUBLE);
            Rectangle rect2 = new Rectangle(15, 13, BorderStyle.SINGLE);
            Rectangle rect3 = new Rectangle(24, 14, BorderStyle.DOTTED);

            BinaryFormatter formatter = new BinaryFormatter();

            FileStream filestream = new FileStream("Rectangle.binary", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (filestream)
                {
                    formatter.Serialize(filestream, rect1);
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured");

            }
        }

        private static void deserialize()
        {
            Rectangle rect1 = new Rectangle(0, 0, BorderStyle.SINGLE);


            BinaryFormatter formatter = new BinaryFormatter();

            FileStream filestream = new FileStream("Rectangle.binary", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (filestream)
                {
                    rect1 = (Rectangle)formatter.Deserialize(filestream);
                    Console.WriteLine(rect1.Height);
                    Console.WriteLine(rect1.Width);
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured");

            }
        }
    }
}
