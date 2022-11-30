using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpretEnSimpleKlasse
{
    internal class Kat
    {
        public string? Farve { get; set; }
        public void SkiftFarve()
        {
            Farve = "gul";
        }
    }
}
