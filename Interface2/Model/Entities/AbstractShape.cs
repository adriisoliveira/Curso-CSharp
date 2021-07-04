using Interface2.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface2.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
