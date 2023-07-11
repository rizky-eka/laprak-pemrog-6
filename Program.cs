namespace prak6
{
  internal class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new Mobil();
            mobil1.setWarna("Hitam");
            mobil1.setMerk("Daihaha");
            mobil1.setModel("Cylock");
            mobil1.setTahun_keluaran("2018");
            mobil1.setKecepatan("60 km/jam");
            mobil1.setSuara("TIINTINNNN");
            mobil1.setJumlah_pintu("5");

            Console.WriteLine("Warna mobil1 : " + mobil1.getWarna());
            Console.WriteLine("Merk mobil1 : " + mobil1.getMerk());
            Console.WriteLine("Model mobil1 : " + mobil1.getModel());
            Console.WriteLine("Tahun keluar mobil1 : " + mobil1.getTahun_keluaran());
            Console.WriteLine("Kecepatan mobil1 : " + mobil1.getKecepatan());
            Console.WriteLine("Suara mobil1 : " + mobil1.getSuara());
            Console.WriteLine("Jumlah pintu mobil1 : " + mobil1.getJumlah_pintu());

            Console.ReadLine();
        }
    }
}