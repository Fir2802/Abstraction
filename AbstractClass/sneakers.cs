using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class sneakers : fashion
    {
        public override void sepatu()
        {
            Console.WriteLine("abstract class");
            Console.WriteLine("sepatu yang populer bagi anak muda adalah sepatu sneakers.");
            Console.WriteLine("sepatu yang digunakan dalam kegiatan kasual,sepatu ini tersedia dalam banyak model dan warna.");
        }
    }
}