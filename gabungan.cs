using System;
 namespace gabungan
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       KaryawanTetap karyawanTetap = new KaryawanTetap();
       karyawanTetap.NIK = "1111";
       karyawanTetap.Nama = "Satu Setiawan";
       karyawanTetap.GajiBulanan = 15000000;
       
       KaryawanHarian karyawanHarian = new KaryawanHarian();
       karyawanHarian.NIK = "1112";
       karyawanHarian.Nama = "Dua Prasetya";
       karyawanHarian.UpahPerJam = 50000;
       karyawanHarian.JumlahJamKerja = 10;
       
       Sales sales = new Sales();
       sales.NIK = "0001";
       sales.Nama = "Tiga Putra";
       sales.JumlahPenjualan = 20;
       sales.Komisi = 75000;
       
       List<Karyawan> karyawan = new List<Karyawan>();
       
       karyawan.Add(karyawanTetap);
       karyawan.Add(karyawanHarian);
       karyawan.Add(sales);
       
       Console.WriteLine("==================================================");
       Console.WriteLine(" NO | NIK / NAMA\t\t\t\t | Gaji\t\t |");
       Console.WriteLine("==================================================");
       for ( int i = 0; i < karyawan.Count; i++) {
         
            Console.WriteLine(" {0}. | {1} {2} \t\t| {3} \t |", i+1, karyawan[i].NIK, karyawan[i].Nama, karyawan[i].Gaji());
       }
       
       Console.ReadKey();
     }
   }
   
   public abstract class Karyawan {
     public string NIK;
     public string Nama;
     public abstract double Gaji();
   }
   
   public class KaryawanTetap : Karyawan {
     public double GajiBulanan;
     public override double Gaji() {
       return this.GajiBulanan;
     }
   }
   
   public class KaryawanHarian : Karyawan {
     public double UpahPerJam;
     public double JumlahJamKerja;
     public override double Gaji() {
       return this.UpahPerJam * this.JumlahJamKerja;
     }
   }
   
   public class Sales : Karyawan {
     public double JumlahPenjualan;
     public double Komisi;
     public override double Gaji() {
       return this.JumlahPenjualan * this.Komisi;
     }
   }
 }