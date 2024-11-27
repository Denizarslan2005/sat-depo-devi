
Console.WriteLine("gelen ürünün ismini giriniz");

string ürün1 = Convert.ToString(Console.ReadLine());

Console.WriteLine("ürünün miktarını giriniz");

int miktar1 = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("gelen ürün depoya gidecek ise 1'e rafa dizilecek ise 2'ye basınız.");
int karar = Convert.ToInt32(Console.ReadLine());

while (true)
{
    if (karar==1)
    {
        Console.WriteLine("deponun kapasitesi ne kadar?");
        int depo=Convert.ToInt32(Console.ReadLine());
        if (depo<miktar1)
        {
            Console.WriteLine("ürün depo kapasitesini aşıyor.daha az miktar belirleyin");
            miktar1 = Convert.ToInt32 (Console.ReadLine());
            if (depo>miktar1)
            {
                Console.WriteLine("ürün depoya gönderilecek.");
                depo = depo-miktar1;
                Console.WriteLine("depoda kalan yer miktarı="+depo);
            }


        }
        else
        {
            Console.WriteLine("ürün depoya gönderilecek.");
            depo = depo- miktar1;
            Console.WriteLine("depoda kalan yer miktarı="+depo);
        }
    }
    else if ( karar==2)
    {
        Console.WriteLine("rafın kapasitesi ne kadar?");
        int raf = Convert.ToInt32(Console.ReadLine());
        if (raf<miktar1)
        {
            Console.WriteLine("ürün miiktarı raf kapasitesini aşıyor.lütfen daha az miktar belirleyin.");
            miktar1 = Convert.ToInt32(Console.ReadLine());
            if (raf>miktar1)
            {
                Console.WriteLine("ürün rafa dizilecek.");
            }

        }
        else
        {
            Console.WriteLine("ürün rafa dizilecek.");
        }
    }
    break;
}

Console.WriteLine(" ürünün geliş fiyatı ne kadar?");

double gelis_fiyat = Convert.ToDouble(Console.ReadLine());
double kdv = 20;

double toplam_fiyat = gelis_fiyat * miktar1;
Console.WriteLine("ürünün toplam geliş fiyatı="+toplam_fiyat);
double satıs_fiyat = gelis_fiyat+((gelis_fiyat * kdv)) / 100;
Console.WriteLine("gelen ürünün kdv'li satış fiyatı=" + satıs_fiyat);














