using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace op
{
    internal class Phone
    {
        public string processor { get; set; }
        public double screen { get; set; }
        public void phone()
        {
            Console.WriteLine("Phone: Iphone 14");
        }
        public void Color()
        {
            Console.WriteLine("Color: Black");
        }
        public void musicringtone()
        {
            Console.WriteLine("musicringtone: Marimba");
        }
        class Iphone : Phone
        {
            static void Main(string[] args)
            {
                Phone phone = new Phone();
                phone.processor = "A15 Bionic";
                phone.screen = 6.1;
                phone.phone();
                phone.Color();
                phone.musicringtone();
                Console.WriteLine("Proccessor: " + (phone.processor));
                Console.WriteLine("Screen: " + (phone.screen));
                Console.ReadKey();
            }
        }
    }

}

