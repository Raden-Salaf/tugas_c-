using System;

class Program
{
    static void Main()
    {
        // Input data mahasiswa
        Console.Write("Masukkan nama mahasiswa: ");
        string nama = Console.ReadLine();

        Console.Write("Masukkan nilai harian: ");
        int nilaiHarian = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan nilai UTS: ");
        int nilaiUTS = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan nilai UAS: ");
        int nilaiUAS = Convert.ToInt32(Console.ReadLine());

        // Menghitung nilai akhir
        int nilaiAkhir = (nilaiHarian + nilaiUTS + nilaiUAS) / 3;

        // Menghitung rata-rata nilai
        double rataRata = (nilaiHarian + nilaiUTS + nilaiUAS) / 3.0;

        // Menentukan predikat nilai
        string predikat;
        if (nilaiAkhir >= 80)
        {
            predikat = "A";
        }
        else if (nilaiAkhir >= 70)
        {
            predikat = "B";
        }
        else if (nilaiAkhir >= 60)
        {
            predikat = "C";
        }
        else if (nilaiAkhir >= 50)
        {
            predikat = "D";
        }
        else
        {
            predikat = "E";
        }

        // Menampilkan hasil
        Console.WriteLine($"Nama: {nama}");
        Console.WriteLine($"Nilai Akhir: {nilaiAkhir}");
        Console.WriteLine($"Rata-rata Nilai: {rataRata}");
        Console.WriteLine($"Predikat nilai: {predikat}");
    }
}
