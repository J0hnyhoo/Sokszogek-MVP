﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek_MVP.Models
{
    public abstract class sokszog
    {
        public double oldalA { get; set; }
        public double oldalB { get; set; }
        public abstract double Kerulet();
        public abstract double Terulet();
        public sokszog(double A, double B)
        {
            oldalA = A;
            oldalB = B;
        }
    }
}
