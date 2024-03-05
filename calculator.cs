class Calculator
{
static void main(string[] args)
	{
	Console.Title = "Aplikasi Oyyyyy";

            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Pilih Salah Satu\n 1. Penambahan\n 2. Pengurangan\n 3. Perkalian\n 4. Pembagian");
            int pilih = int.Parse(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                    break;
                case 2:
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b));
                    break;
                case 3:
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2} ", a, b, Perkalian(a, b));
                    break;
                case 4:
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2} ", a, b, Pembagian(a, b));
                    break;
                default :
                    Console.WriteLine("Pilihan Anda Salah");
                    break;
            }

            Console.WriteLine("\nTekan Sembarang Untuk Keluar");
            Console.ReadKey();

        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static float Pembagian(float a, float b)
        {
            return a / b;
        }
	}	
	
	
}