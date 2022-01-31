using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp56
{
    class Barricades : GameObject, IFence
    {
        public Barricades(Coordinates coordinates, string icon) : base(coordinates, icon) { }
        public Barricades(string icon) : base(icon) { }

        public void Hi()
        {
            throw new NotImplementedException();
        }
    }
}
