namespace prak6
{
  internal class Mobil
    {
        private string? warna;
        private string? merk;
        private string? model;
        private string? tahun_keluaran;
        private string? kecepatan;
        private string? suara;
        private string? jumlah_pintu;

        public void setWarna(string newWarna)
        {
            warna = newWarna;
        }
        public string getWarna()
        {
            return warna;
        }

        public void setMerk(string newMerk)
        {
            merk = newMerk;
        }
        public string getMerk()
        {
            return merk;
        }


        public void setModel(string newModel)
        {
            model = newModel;
        }
        public string getModel()
        {
            return model;
        }


        public void setTahun_keluaran(string newTahun_keluaran)
        {
            tahun_keluaran = newTahun_keluaran;
        }
        public string getTahun_keluaran()
        {
            return tahun_keluaran;
        }


        public void setKecepatan(string newKecepatan)
        {
            kecepatan = newKecepatan;
        }
        public string getKecepatan()
        {
            return kecepatan;
        }


        public void setSuara(string newSuara)
        {
            suara = newSuara;
        }
        public string getSuara()
        {
            return suara;
        }


        public void setJumlah_pintu(string newJumlah_pintu)
        {
            jumlah_pintu = newJumlah_pintu;
        }
        public string getJumlah_pintu()
        {
            return jumlah_pintu;
        }
    }
}