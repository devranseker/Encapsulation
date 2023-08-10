namespace Encapsulation;
/*
Musteri sınıfının üyeleri public olarak bildirildiği için bu üyelere doğrudan erişilip değerler atanabilir.
İşte bu noktada kontrolü elimize almamız lazım aksi taktirde
TC kimlik numarası eksik/fazla girilebilir veya
120 odalı bir otelde oda numarası negatif veya 120’den büyük girilebilir.
Amacımız dikkatsizlik sonucu yaşanabilecek olası sorunların önüne geçmek.
Bu yüzden üyelere doğrudan erişimi engelleyip (Private), Get ve Set metotları ile kontrollü bir erişim sağlayacağız.
class Animals
*/
class Customer{
    private string Name;
    private long Tc;
    private int RoomNumber;

    public string name
    {
        get
        {
            return Name;
        }
        set
        {
            Name = value;
        }
    }

    public long tc
    {
        get
        {
            return Tc;
        }

        set
        {
            if(value.ToString().Length == 11)
            {
                Tc = value;
            }
            else
            {
                Console.WriteLine("Tc nizi hatalı girdiniz.");
               
            }
        }
    }


    public int roomNumber
    {

        get
        {
            return RoomNumber;
        }
        set
        {
            if(value<=0 || value > 120)
            {
                Console.WriteLine("Hatalı oda sayısı girdiniz!");
            }
            else
            {
                RoomNumber = value;
            }
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        //Encapsulation
        //dış dünyadan gelen erişimi sınırlamak için kullanılan bir nesne yönelimli programlama (OOP) prensibidir
        // bir sınıfın içindeki verilerin korunmasını ve doğru erişimini sağlamayı hedefler.

        Customer customer = new Customer();
        customer.name = "Eyyüp Erdoğan";
        customer.tc = 54346657434;
        customer.roomNumber = 45;

        Console.WriteLine("Ad Soyad:" + customer.name+"  "+"Tc No:"+customer.tc+"  "+"Oda Numarası:"+ customer.roomNumber);
        Console.Read();
    }
}

