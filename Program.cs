using System.ComponentModel.Design;

namespace ODEV2_do_while_dongusu_16_02_2023
{
    internal class Program
    {
        #region PIN-PUK KODU
        static void Main(string[] args)

        {

            Console.Write("Lütfen 4 Haneli PIN Kodunuzu Giriniz : ");

            string PINKodu = Console.ReadLine();

            Console.Clear();

            int hak = 1;

            while (true)

            {
                Console.Write(hak + ". Hakkınız\n\nPIN Kodunuzu Giriniz : ");

                string girilen = Console.ReadLine();

                if (girilen == PINKodu)

                {
                    Console.Clear();

                    Console.Write("\n TELEFONUNUZ AÇILIYOR...");

                    break;
                }

                else if (girilen != PINKodu && hak > 2)

                {
                    Console.Clear();

                    Console.Write("\nPUK KODUNUZ İSTENİYOR!!! ");

                    break;
                }

                hak++;

                Console.Clear();

            }

            Console.Write("\n\nLütfen 8 Haneli PUK Kodunuzu Giriniz : ");

            string PUKKodu = Console.ReadLine();

            Console.Clear();

            int Hak = 1;

            while (true)

            {
                Console.Write(Hak + ". Hakkınız\n\nPUK Kodunuzu Giriniz : ");

                string girilen = Console.ReadLine();

                if (girilen == PUKKodu)

                {
                    Console.Clear();

                    Console.Write("\n TELEFONUNUZ AÇILIYOR...");

                    break;
                }

                else if (girilen != PUKKodu && Hak > 9)

                {
                    Console.Clear();

                    Console.Write("\nEYVAH!HATTINIZ BLOKE OLDU.");

                    Console.WriteLine();

                    Console.Write("\nLütfen Müşteri Hizmetlerini Arayınız!!!");

                    break;
                }

                Hak++;

                Console.Clear();
            }

            Console.ReadLine();
        }

    }

}
#endregion
