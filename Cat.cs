using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyExample
{
    internal class Cat: Animal
    {
        public string Color { get; set; }

        public void Meow() { Console.WriteLine("냥냥 웁니다."); }
    }
}
