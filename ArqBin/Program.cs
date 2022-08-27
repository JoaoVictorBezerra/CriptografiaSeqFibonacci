using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static int Fibonnaci(int termo)
        {
            return (termo == 1 || termo == 2 ? 1 : (Fibonnaci(termo - 1) + Fibonnaci(termo - 2)));
            //if (termo == 1 || termo == 2 ? 1 : (Fibonnaci(termo -1 ) + Fibonnaci(termo - 2))
            //{
            //    return 1;
            //}
            //else
            //{
            //    return Fibonnaci(termo - 1) + Fibonnaci(termo - 2);
            //}
        }
        static void Main(string[] args)
        {
            FileStream iofile;
            int tam;
            char x;

            iofile = new System.IO.FileStream("teste.txt",
                                               System.IO.FileMode.Open,
                                               System.IO.FileAccess.ReadWrite);

            tam = (int)iofile.Length;
            for (int i = 0; i < tam; ++i)
            {
                x = (char)(iofile.ReadByte()-5);
                --iofile.Position;
                iofile.WriteByte((byte)x);
            }
            iofile.Close();

            for(int i = 1; i < 11; ++i)
            {
                Console.WriteLine(Fibonnaci(i));
            }
            Console.ReadKey();
        }
    }
}
