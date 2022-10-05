using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore
{
    internal class Shoe
    {
        public Style Style { get; private set; }
        public string Color { get; private set; }
        public string Description { get { return $"A {Color} {Style}"; } }
        public Shoe(Style style, string color)
        {
            this.Style = style;
            this.Color = color;
        }

    }

}
