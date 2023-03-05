// See https://aka.ms/new-console-template for more information

string adi = "Murat";
int yas = 30;

Kurs kurs1=new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Murat Durmuş";
kurs1.IzlenmeOrani = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.Egitmen = "Berkan Namlıkaya";
kurs2.IzlenmeOrani = 54;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Phyton";
kurs3.Egitmen = "Oğuzhan Emiroğlu";
kurs3.IzlenmeOrani = 49;

//Console.WriteLine(kurs1.KursAdi+ " : " + kurs1.Egitmen);

Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
}





//Console.WriteLine("Hello, World!");









class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}