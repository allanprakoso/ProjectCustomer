using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih menu Aplikasi\n");
            Console.WriteLine("1. Tambah Customer");
            Console.WriteLine("2. Hapus Customer");
            Console.WriteLine("3. Tampilkan Customer");
            Console.WriteLine("4. Keluar");
        }

        static void TambahCustomer()
        {
            Console.Clear();
            Customer customer = new Customer();
            Console.WriteLine("Tambah Data Customer\n");
            Console.Write("Kode Customer : ");
            customer.Kode = Console.ReadLine();
            Console.Write("Nama Customer : ");
            customer.Nama = Console.ReadLine();
            Console.Write("Total Piutang : ");
            customer.Piutang = double.Parse(Console.ReadLine());
            daftarCustomer.Add(customer);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            int nourut = 0;
            bool ditemukan = false;
            Console.WriteLine("Hapus Data Customer\n");
            Console.Write("Kode Customer : ");
            string searchKode = Console.ReadLine();
            foreach (Customer customer in daftarCustomer)
            {
                if (customer.Kode == searchKode)
                {
                    ditemukan = true;
                    break;
                }
                nourut++;
            }
            if (ditemukan == true)
            {
                daftarCustomer.RemoveAt(nourut);
                Console.WriteLine("\nData Customer Berhasil Dihapus");
            }
            else
                Console.WriteLine("\nKode Customer Tidak Ditemukan");

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();
            int nourut = 0;
            Console.WriteLine("Data Customer\n");
            foreach (Customer customer in daftarCustomer)
            {
                nourut++;
                Console.WriteLine("{0}. {1} , {2} , {3}",
                nourut, customer.Kode, customer.Nama, customer.Piutang);
            }
            if (nourut <= 0)
                Console.WriteLine("Data Kosong");

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
