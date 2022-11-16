class Telefon
{
    public string isim;
    public string soyisim;
    public int telefonnumarası;

    public int guncelno;

    public void TelefonBilgileri()
    {
        Console.WriteLine("Kişinin adı: {0} ",isim);
        Console.WriteLine("Kişinin soyismi: {0} ",soyisim);
        Console.WriteLine("Kişinin telefon numarası: {0} ",telefonnumarası);
        
    }
    public void TelefonGuncelleme()
    {
        Console.WriteLine("Kişinin yeni telefon numarası: {0} ",guncelno);
    }
}
