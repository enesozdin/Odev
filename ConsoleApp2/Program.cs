using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasitLib;

namespace Odev

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oluşturulacak dosyanın adını giriniz");
            string dosya = @"C:\Users\Enes\Desktop\" + Console.ReadLine() + ".txt";
            if (File.Exists(dosya) == true)
            {
                Console.WriteLine("Dosya zaten var");
            }
            else
            {
                Console.WriteLine("Dosya oluşturuluyor.");
            }
            FileStream fs = new FileStream(dosya, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Tasit araba = new Tasit();
            int TasitSayi = 0;
            Console.WriteLine("Kac tane tasit girliecek?");
            TasitSayi = int.Parse(Console.ReadLine());
            string[,] arr = new string[TasitSayi + 1, 9];
            arr[0, 0] = "Marka";
            arr[0, 1] = "Model";
            arr[0, 2] = "Y.Sayısı";
            arr[0, 3] = "Max Hız";
            arr[1, 0] = araba.Marka;
            arr[1, 1] = araba.Model;
            arr[1, 2] = araba.Yolcusayisi;
            arr[1, 3] = araba.Maxhiz;

                for (int i = 1; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (j == 0)
                        {
                            Console.WriteLine("Lutfen markayi giriniz:");
                            arr[i, 0] = Console.ReadLine();
                        }
                        if (j == 1)
                        {
                            Console.WriteLine("Lutfen modeli giriniz:");
                            arr[i, 1] = Console.ReadLine();
                        }
                        if (j == 2)
                        {
                            Console.WriteLine("Yolcu sayisini giriniz:");
                            arr[i, 2] = Console.ReadLine();
                        }
                        if (j == 3)
                        {
                            Console.WriteLine("Maximum hizi giriniz");
                            arr[i, 3] = Console.ReadLine();
                        }
                    }
                }
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        sw.Write(arr[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                    sw.Flush();
                    sw.Close();
                    fs.Close();

        }
    }
}