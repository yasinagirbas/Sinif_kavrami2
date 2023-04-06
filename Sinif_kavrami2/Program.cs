namespace Sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //söz dizini 
            //class sınıf Adı
            // {
            // (erişim belirleyici ) (veri tipi)  özellik adı;
            //(erişim Belirleyici ) (geri dönüş tipi) Metotadı(parametre listesi) 
            //{
            //Metot komutları
            // }
            //}

            //Erişim belirleyiciler
            // * Public her yerden erişilebilir 
            // * Private sadece tanımlandığı sınıf içerisinde erişilebilir proportiler 
            // * Internal sadece o proje içerinde erişilebilen kendi projesi içerisinde erişilebilien değişken ve metotlara 
            // * Protected  sadece tanımlandığı sınıfta ve diğer sınıflardan miras alan kalıtım alan nesne yönelimlidir.
            Calisan calisan1 = new Calisan(); // çalışanın 1 örneğini yaptık
            calisan1.Ad = "Yasin";
            calisan1.Soyad = "Ağırbaş";
            calisan1.No = 50;
            calisan1.Departman = "Bilgi İşlem";
            calisan1.calisanbilgiler();
            Console.WriteLine("**************** calısan 2 ************");

            Calisan calisan2 = new Calisan("deniz","arada",21,"satınalma");
            calisan2.calisanbilgiler();

        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad; // bu sınıfın elemanı demektir
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan()
        {
            
        }


    public void calisanbilgiler()
        {
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışan no:{0}",No);
            Console.WriteLine("Çalışan Departman:{0}",Departman);
        }
    }
    
}