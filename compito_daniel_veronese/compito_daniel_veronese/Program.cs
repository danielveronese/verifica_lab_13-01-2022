using System;

namespace Treni
{
    class Treni
    {
        int costo;
        string nome;
        string codtreno;
   

        public int  costotreno()
        {

            costo = 100000;



            return costo;   
        }




    }

    class Treni_passeggeri : Treni
    {
        int costo;
        int numnumvagoni;
        string alimentazione;
        int numkilometri;
        int costokilomeri;
        int costo_tot;

        public int costotreno_passegeri()
        {
            costo = 125000;


            return costo;

        }

        public int costokm()
        {
            numkilometri = Convert.ToInt32(Console.ReadLine());
            costokilomeri = numkilometri * 150;




            return costokilomeri;
        }

        public int calcolo_costo_tot()
        {
            costo_tot = costo + costokilomeri;

            Console.WriteLine("il costo totale è di {0} euro ", costo_tot);

            return costo_tot;

        }




    }
    class Treni_merci : Treni
    {

        int costo;
        int numnumvagoni;
        string alimentazione;
        int numkilometri;
        int costokilomeri;
        int costo_tot;

        public int costotreno_merci()
        {
            costo = 135000;


            return costo;

        }

        public int costokm()
        {
            numkilometri =Convert.ToInt32(Console.ReadLine());    
            costokilomeri = numkilometri * 100;




            return costokilomeri;
        }
        public int calcolo_costo_tot()
        {
            costo_tot = costo + costokilomeri;

            Console.WriteLine("il costo totale è di {0} euro ", costo_tot);

            return costo_tot;

        }


    }



    class program
    {

        static void Main(string[] args)
        {
            int i;
            Treni t = new Treni();
            Treni_passeggeri tp = new Treni_passeggeri();
            Treni_merci tm = new Treni_merci();

            Console.WriteLine("che treno vuoi aquistare? premi 1 per il treno  passeggeri oppure premi 2 per il treno  merci");
            i=Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                tp.costotreno_passegeri();

                Console.WriteLine("quanti kilomtri devi percorrere?");
                tp.costokm();
                tp.calcolo_costo_tot();

                









            }
            else
            {
                if (i == 2)
                {
                    tm.costotreno_merci();
                    Console.WriteLine("quanti kilomtri devi percorrere?");
                    tm.costokm();
                    tm.calcolo_costo_tot();






                }









            }










        }



    }


}