using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasitLib
{
    public class Tasit //Bisiklet,Gemi,Motosiklet,Tren,Uçak
    {
        //KAPI SAYISI, MAX HIZ,

        private string marka;

        public string Marka { get => marka; set => marka = value.ToUpper(); }

        private string model;

        public string Model { get => model; set => model = value; }

        private string yolcusayisi;
        //int
        public string Yolcusayisi { get => yolcusayisi; set => yolcusayisi = value; }
        public string Maxhiz { get => maxhiz; set => maxhiz = value; }
        //int
        private string maxhiz;
        //--------------------------------------------
        private string pruva;
        private string güverte;
        private string lokomotif;
        private string peron;
        //-----------------------------------------------
        //private int yolcusayisi;

        //public int Yolcusayisi
        //{
        //    get { return yolcusayisi; }
        //    set { yolcusayisi = value; }
    }

    

    public class Araba:Tasit
    {
        //public Araba()
        //{

        //}
       //public Araba(string marka, string model)
        //{
        //    this.Marka = marka;
        //    this.Model = model;

        //}
        //public string Marka { get; set; }//prop
        //public string Model { get; set; }//prop

    }
}