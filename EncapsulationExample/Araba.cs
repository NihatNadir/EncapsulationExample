using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    internal class Araba
    {

        // Özelliklerimizden(Property) Kapı sayısı için kapsülleme işlemi yapmak istiyoruz.
        // Eğer bir Araba nesnesi oluşturulduğunda Kapı Sayısı için 2 veya 4 dışında bir değer atanmak isterse konsol ekranında bir uyarı mesajı yayınlayalım ve Kapı Sayısı değerini -1 olarak atayalım.


        private string _brand;
        private string _model;
        private string _color;
        private int _doorCount;

        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _brand = value;

                else
                    Console.WriteLine("Arabanın markası boş olamaz.");

            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _model = value;

                else
                    Console.WriteLine("Arabanın modeli boş olamaz.");
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _color = value;
                else
                    Console.WriteLine("Arabanın rengi boş olamaz.");
            }
        }

        public int DoorCount
        {
            get
            {
                return _doorCount;
            }
            set
            {
                if (value == 2 || value == 4)
                {

                    _doorCount = value;
                }
                else
                {
                    _doorCount = -1;
                    Console.WriteLine("Kapı sayınız 2 yada 4 değil\n");
                }
            }
        }

        public Araba()
        {

        }

        public Araba(string brand, string model, string color, int doorCount)
        {
            Brand = brand;
            Model = model;
            Color = color;
            DoorCount = doorCount;

        }

        public void TellInfo()
        {
            
                Console.WriteLine($"Arabanın markası : {_brand}\nArabanın modeli : {_model}\nArabanın rengi : {_color}\nArabanın kapı sayısı : {_doorCount}");
        }
    }
}
