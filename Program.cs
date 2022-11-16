        Telefon telefon1 = new Telefon();
        telefon1.isim="Hüseyin";
        telefon1.soyisim="Yılmaz";
        telefon1.telefonnumarası = 1234567891;

        Telefon telefon2 = new Telefon();
        telefon2.isim="Teoman";
        telefon2.soyisim="Lokma";
        telefon2.telefonnumarası = 1234567892;
        
        Telefon telefon3 = new Telefon();
        telefon3.isim="Altay";
        telefon3.soyisim="Cavik";
        telefon3.telefonnumarası = 1234567893;

        Telefon telefon4 = new Telefon();
        telefon4.isim="Melisa";
        telefon4.soyisim="Torlak";
        telefon4.telefonnumarası = 1234567894;

        Telefon telefon5 = new Telefon();
        telefon5.isim="Sina";
        telefon5.soyisim="Parlak";
        telefon5.telefonnumarası = 1234567895;

        Console.WriteLine("(1) Yeni Numara Kaydetmek");
        Console.WriteLine("(2) Varolan Numarayı Silmek");
        Console.WriteLine("(3) Varolan Numarayı Güncelleme");
        Console.WriteLine("(4) Rehberi Listelemek");
        Console.WriteLine("(5) Rehberde Arama Yapmak");
        Console.WriteLine("******************************");
        Console.Write("Yapmak istediğiniz işlemi seçiniz: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a == 1)
        {
            Console.Write("Lütfen isim giriniz: ");
            string kayıt = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz: ");
            string kayıt1 = Console.ReadLine();
            Console.Write("Lütfen numara giriniz: ");
            int kayıt2 = Convert.ToInt32(Console.ReadLine());
            Telefon yeni = new Telefon();
            yeni.isim = kayıt;
            yeni.soyisim = kayıt1;
            yeni.telefonnumarası = kayıt2;
            Console.WriteLine("İŞLEM BAŞARILI!");
            yeni.TelefonBilgileri();
        }
        else if (a == 2)
        {
            Console.Write("Lütfen isim veya soyisim giriniz: ");
            string sil = Console.ReadLine();
            if (telefon1.isim.Equals(sil) | telefon1.soyisim.Equals(sil))
            {
                Console.Write("{} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n): ");
                string kisi = Console.ReadLine();
                if (kisi == "y")
                {
                    Console.WriteLine("Kişi Silindi");
                }
                else if (kisi == "n")
                {
                    Console.WriteLine("İşlem sonlandırılıyor...");
                }
            }
            else if (telefon2.isim.Equals(sil) | telefon2.soyisim.Equals(sil))
            {
                Console.Write("{} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n): ");
                string kisi = Console.ReadLine();
                if (kisi == "y")
                {
                    Console.WriteLine("Kişi Silindi");
                }
                else if (kisi == "n")
                {
                    Console.WriteLine("İşlem sonlandırılıyor...");
                }
            }
            else if (telefon3.isim.Equals(sil) | telefon3.soyisim.Equals(sil))
            {
                Console.Write("{} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n): ");
                string kisi = Console.ReadLine();
                if (kisi == "y")
                {
                    Console.WriteLine("Kişi Silindi");
                }
                else if (kisi == "n")
                {
                    Console.WriteLine("İşlem sonlandırılıyor...");
                }
            }
            else if (telefon4.isim.Equals(sil) | telefon4.soyisim.Equals(sil))
            {
                Console.Write("{} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n): ");
                string kisi = Console.ReadLine();
                if (kisi == "y")
                {
                    Console.WriteLine("Kişi Silindi");
                }
                else if (kisi == "n")
                {
                    Console.WriteLine("İşlem sonlandırılıyor...");
                }
            }
            else if (telefon5.isim.Equals(sil) | telefon5.soyisim.Equals(sil))
            {
                Console.Write("{} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n): ");
                string kisi = Console.ReadLine();
                if (kisi == "y")
                {
                    Console.WriteLine("Kişi Silindi");
                }
                else if (kisi == "n")
                {
                    Console.WriteLine("İşlem sonlandırılıyor...");
                }
            }
            else
            {
                Console.WriteLine("Lütfen İşlem seçiniz...");
            }

        }
        else if (a == 3)
        {
            Console.Write("Lütfen numarasını Değiştirmek istediğiniz kişinin adını ya da soyadını giriniz:  ");
            string sil3 = Console.ReadLine();            
            if (telefon1.isim.Equals(sil3) | telefon1.soyisim.Equals(sil3))
            {
                Console.WriteLine("Numarayı giriniz: ");
                int yeni_no = Convert.ToInt32(Console.ReadLine());
                telefon1.telefonnumarası = yeni_no;
                telefon1.TelefonBilgileri();
            }
            else if (telefon2.isim.Equals(sil3) | telefon2.soyisim.Equals(sil3))
            {
                Console.WriteLine("Numarayı giriniz: ");
                int yeni_no = Convert.ToInt32(Console.ReadLine());
                telefon2.telefonnumarası = yeni_no;
                telefon2.TelefonBilgileri();
            }
            else if (telefon3.isim.Equals(sil3) | telefon3.soyisim.Equals(sil3))
            {
                Console.WriteLine("Numarayı giriniz: ");
                int yeni_no = Convert.ToInt32(Console.ReadLine());
                telefon3.telefonnumarası = yeni_no;
                telefon3.TelefonBilgileri();
            }
            else if (telefon4.isim.Equals(sil3) | telefon4.soyisim.Equals(sil3))
            {
                Console.WriteLine("Numarayı giriniz: ");
                int yeni_no = Convert.ToInt32(Console.ReadLine());
                telefon4.telefonnumarası = yeni_no;
                telefon4.TelefonBilgileri();
            }
            else if (telefon5.isim.Equals(sil3) | telefon5.soyisim.Equals(sil3))
            {
                Console.WriteLine("Numarayı giriniz: ");
                int yeni_no = Convert.ToInt32(Console.ReadLine());
                telefon5.telefonnumarası = yeni_no;
                telefon5.TelefonBilgileri();
            }

        }
        else if (a == 4)
        {
            telefon1.TelefonBilgileri();
            telefon2.TelefonBilgileri();
            telefon3.TelefonBilgileri();
            telefon4.TelefonBilgileri();
            telefon5.TelefonBilgileri();

        }
        else if ( a == 5)
        {
            Console.WriteLine("(1)İsim veya soyisme göre aramak yapmak için: ");
            Console.WriteLine("(2)Telefon numarasına göre aramak yapmak için: ");
            Console.Write("Değer giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b == 1)
            {
                Console.Write("İsim veya Soyisim giriniz: ");
                string ara = Console.ReadLine();
            if (telefon1.isim.Equals(ara) | telefon1.soyisim.Equals(ara))
            {
                telefon1.TelefonBilgileri();
            }
            else if (telefon2.isim.Equals(ara) | telefon2.soyisim.Equals(ara))
            {
                telefon2.TelefonBilgileri();
            }
            else if (telefon3.isim.Equals(ara) | telefon3.soyisim.Equals(ara))
            {
                telefon3.TelefonBilgileri();
            }
            else if (telefon4.isim.Equals(ara) | telefon4.soyisim.Equals(ara))
            {
                telefon4.TelefonBilgileri();
            }
            else if (telefon5.isim.Equals(ara) | telefon5.soyisim.Equals(ara))
            {
                telefon5.TelefonBilgileri();
            }

            }
            else if (b == 2)
            {
            Console.Write("Kişinin numarasını giriniz: ");
            string ara = Console.ReadLine();
            if (telefon1.telefonnumarası.Equals(ara))
            {
                telefon1.TelefonBilgileri();
            }
            else if (telefon2.telefonnumarası.Equals(ara))
            {
                telefon2.TelefonBilgileri();
            }
            else if (telefon3.telefonnumarası.Equals(ara))
            {
                telefon3.TelefonBilgileri();
            }
            else if (telefon4.telefonnumarası.Equals(ara))
            {
                telefon4.TelefonBilgileri();
            }
            else if (telefon5.telefonnumarası.Equals(ara))
            {
                telefon5.TelefonBilgileri();
            }
            else
            {
                Console.WriteLine("Herhangi bir bilgi bulunamadı...");
                
            }
            }
            {

            }
        }