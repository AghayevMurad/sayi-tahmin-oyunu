




namespace sayi_tahmin
{

    class Program
    {


        static void Main(string[] args)
        {


            Console.WriteLine("**** Sayi tahmin etme oyunu ****");
            Console.WriteLine();
            Console.WriteLine("**** oyunun serteleri sayiyi 1 den basliyarak 2 2 atliyarak yaziniz ****");

            Console.Write("1.ci sayi: ");
            int i;
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.ci sayi: ");
            Console.ReadLine();
            Console.Write("3.cu sayi: ");
            Console.ReadLine();
            Console.Write("4.cu sayi: ");
            Console.ReadLine();
            Console.Write("5.ci sayi: ");
            Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("Sizi tebrik ediyoruz Siz sayi tahmin etme oyununu kazandinz :) ");
            Console.WriteLine();



            Console.WriteLine("**** Sayi tahmin etme oyunun cavablari ****");
            Console.WriteLine();

            for (i = 1; i < 10; i += 2)
            {

                Console.WriteLine(i);


            }


            Console.ReadLine();



        }






    }






}





