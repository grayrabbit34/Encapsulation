using System;
namespace Encapsulation
{
    public class Car //class
    {
        //fields
        private string _brand;
        private string _model;
        private string _colour;
        private int _doorNumber;

        //overloaded constructor
        public Car(string brand, string model, string colour, int doorNumber)
        {
            Brand = brand;
            Model = model;
            Colour = colour;
            DoorNumber = doorNumber;
        }

        public string Brand //property
        {
            get { return _brand; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _brand = value;
                }
                else
                {
                    Console.WriteLine("Marka ismi boş geçilemez.");
                }

            }
        }

        public string Model
        {
            get { return _model; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _model = value;
                }
                else
                {
                    Console.WriteLine("Model ismi boş geçilemez.");
                }
            }
        }

        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        public int DoorNumber
        {
            get { return _doorNumber; }
            set
            {
                if (value == 2 || value == 4)
                {
                    _doorNumber = value;
                }
                else
                {
                    Console.WriteLine("Geçersiz kapı sayısı girildi.");
                    _doorNumber = -1;
                }
            }
        }


        public void ShowInfo() // bilgileri ekrana yazdıran metot
        {
            Console.WriteLine($"Araba markası: {Brand}, modeli: {Model},  rengi: {Colour}, kapı sayısı: {DoorNumber}");
        }

    }
}

