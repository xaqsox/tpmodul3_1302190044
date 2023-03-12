using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302190044
{

        enum Kelurahan
        {
            Batununggal,
            Kujangsari,
            Mengger,
            Wates,
            Cijaura,
            Jatisari,
            Margasari,
            Sekejati,
            Kebonwaru,
            Maleer,
            Samoja
        }
        enum DoorState
        {
            Terbuka,
            Terkunci
        }

     class KodePos
        {
            public string Kode { get; set; }
           // public string Kelurahan { get; set; }
            public Kelurahan Kelurahan { get; set; }
        }
    public class SebuahPanto
    {
        private DoorState statusnya;

        public SebuahPanto()
        {
            statusnya = DoorState.Terbuka;
        }

        public void Buka()
        {
            if (statusnya == DoorState.Terbuka)
            {
                Console.WriteLine("Pintu Terbuka.");
            }
            else
            {
                Console.WriteLine("Pintu Segera Terbuka.....");
                statusnya = DoorState.Terbuka;
            }
        }

        public void Nutup()
        {
            if (statusnya == DoorState.Terkunci)
            {
                Console.WriteLine("Tutup Pintu");
                statusnya = DoorState.Terkunci;
            }
        }

        public void Status()
        {
            if (statusnya == DoorState.Terkunci)
            {
                Console.WriteLine("Kunci Pintu.....");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KodePos kodepos1 = new KodePos
            {
                Kode = "40266",
                Kelurahan = Kelurahan.Batununggal
            };

            KodePos kodepos2 = new KodePos
            {
                Kode = "40287",
                Kelurahan = Kelurahan.Kujangsari
            };
            KodePos kodepos3 = new KodePos
            {
                Kode = "40267",
                Kelurahan = Kelurahan.Mengger
            };
            KodePos kodepos4 = new KodePos
            {
                Kode = "40256",
                Kelurahan = Kelurahan.Wates
            };
            KodePos kodepos5 = new KodePos
            {
                Kode = "40287",
                Kelurahan = Kelurahan.Cijaura
            };
            KodePos kodepos6 = new KodePos
            {
                Kode = "40286",
                Kelurahan = Kelurahan.Jatisari
            };
            KodePos kodepos7 = new KodePos
            {
                Kode = "40286",
                Kelurahan = Kelurahan.Margasari
            };
            KodePos kodepos8 = new KodePos
            {
                Kode = "40286",
                Kelurahan = Kelurahan.Sekejati
            };
            KodePos kodepos9 = new KodePos
            {
                Kode = "40272",
                Kelurahan = Kelurahan.Kebonwaru
            };
            KodePos kodepos10 = new KodePos
            {
                Kode = "40274",
                Kelurahan = Kelurahan.Maleer
            };
            KodePos kodepos11 = new KodePos
            {
                Kode = "40273",
                Kelurahan = Kelurahan.Samoja
            };



            Console.WriteLine(kodepos1.Kode + "//" + kodepos1.Kelurahan);
            Console.WriteLine(kodepos2.Kode + "//" + kodepos2.Kelurahan);
            Console.WriteLine(kodepos3.Kode + "//" + kodepos3.Kelurahan);
            Console.WriteLine(kodepos4.Kode + "//" + kodepos4.Kelurahan);
            Console.WriteLine(kodepos5.Kode + "//" + kodepos5.Kelurahan);


            SebuahPanto Panto = new SebuahPanto();

            Panto.Status();

            Panto.Nutup();
            Panto.Status();

            Panto.Buka();
            Panto.Status();

            Panto.Buka(); 
        }
    }
}

    

