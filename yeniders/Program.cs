// See https://aka.ms/new-console-template for more information 
{

    {
        //type safety - tip güvenliği
        //Do not repeat yourself - Kendini tekrarlama
        //değer tutucu, alias
        string kategoriEtiketi = "Kategoriler";
        int ogrenciSayisi = 32000;
        double faizOrani = 1.45;
        bool sistemeGirisYapmisMi = false;
        double dolarDun = 7.55;
        double dolarBugun = 7.55;

        if (dolarDun>dolarBugun)
        {
            Console.WriteLine("Azalış Butonu");
        }
        else if (dolarDun < dolarBugun)
        {
            Console.WriteLine("Artış Butonu");
        }
        else
        {
            Console.WriteLine("Değişmedi Butonu");
        }

        if (sistemeGirisYapmisMi == true)
        {
            Console.WriteLine("Kullanıcı Ayarları Butonu");
        }
        else
        {
            Console.WriteLine("Giriş Yap Butonu");
        }

        Console.WriteLine(kategoriEtiketi);



    }






}
