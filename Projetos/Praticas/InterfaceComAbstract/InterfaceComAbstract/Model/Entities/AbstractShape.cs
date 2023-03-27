using InterfaceComAbstract.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceComAbstract.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        protected AbstractShape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
