using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class sport : fashion
    {
        public override void sepatu()
        {
            Console.WriteLine("sepatu untuk kebutuhn olahraga adalah sepatu sport.");
            Console.WriteLine("sepatu sport memiliki jenis sesuai dengan olahraga yang dimainkan.");
        }
    }
}