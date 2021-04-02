using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjectsDemo.App
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Money Price { get; set; }

        public Weight Weight { get; set; }

        public Size Size { get; set; }
    }
}
