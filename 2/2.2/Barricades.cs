using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp56.Abstracts;

namespace ConsoleApp56
{
    class Barricades : Fence
    {
        public Barricades(Coordinates coordinates, string icon) : base(coordinates, icon) { }
        public Barricades(string icon) : base(icon) { }

        public void Hi()
        {
            throw new NotImplementedException();
        }
    }
}
