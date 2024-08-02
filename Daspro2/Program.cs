namespace pertemuan_2;

class Program
{
  static void Main(string[] args)
  {
    // Deklarasi variabel
    string introGame1;
    string introGame2;

    // Mendeklarasikan variabel bilangan bulat 
    int angkaPertama = 2,
        angkaKedua = 5,
        angkaKetiga = 4,
        tebakanPertama,
        tebakanKedua,
        tebakanKetiga,
        hasilTambah = angkaPertama + angkaKedua + angkaKetiga,
        hasilKali = angkaPertama * angkaKedua * angkaKetiga;

    // Mendeklarasikan variabel nilai boolean 
    bool tebakanBerhasil, permainanSelesai;

    // Inisiasi variabel aritmatika
    introGame1 = "Anda adalah agen rahasia yang ditugaskan untuk meretas sebuah server.";
    introGame2 = "Pasword server terdiri dari 3 angka yang tidak diketahui";

    // Tampilkan variabel pada layar
    Console.WriteLine(introGame1);
    Console.WriteLine(introGame2);
    Console.WriteLine("--------------------------");
    Console.WriteLine($"Hasil penjumlahan dari password adalah {hasilTambah}");
    Console.WriteLine("Hasil perkalian dari password adalah " + hasilKali);
    Console.WriteLine("--------------------------");
    Console.Write("Masukkan password pertama : ");
    tebakanPertama = Convert.ToInt32(Console.ReadLine());
    Console.Write("Masukkan password kedua : ");
    tebakanKedua = Convert.ToInt32(Console.ReadLine());
    Console.Write("Masukkan password ketiga : ");
    tebakanKetiga = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("--------------------------");
    // if else aritmatika
    if (tebakanPertama == angkaPertama && tebakanKedua == angkaKedua && tebakanKetiga == angkaKetiga)
    {
      Console.WriteLine("Selamat server anda di hack");
    }
    else
    {
      Console.WriteLine("Anda kurang tepat, server gagal diretas, !!!ALARM MELEDAK!!!");
    }
  }
}
