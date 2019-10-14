using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek_MVP.Models
{
    class Teglalap : sokszog
    {
        public Teglalap(double A, double B) : base(A, B)
        {

        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override double Kerulet()
        {
            return 2 * (oldalA + oldalB);
        }

        public override double Terulet()
        {
            return oldalA*oldalB;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
