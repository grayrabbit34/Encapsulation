using System;

using Encapsulation;

class Program
{
    static void Main(string[] args)
    {

        //// new anahtar kelimesi ile Car sınıfından bir nesne (car1) oluşturulmuştur.
        // new kullanıldığında otomatik olarak constructor çalışır.
        Car car1 = new Car("Volvo", "XC27", "Green", 5);
        Car car2 = new Car("Volvo", "XC27", "Green", 4);

        car1.ShowInfo();
        car2.ShowInfo();
    }

}