using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek_MVP.Repositories
{
    public class SokszogRepository : ISokszogRepository
    {
        public string GetNameByIndex(int index)
        {
            return GetSokSzogek().ElementAt(index);
        }

        public IList<string> GetSokSzogek()
        {
            List<string> sokszogek = new List<string>
            {
                "-- kérem válasszon--",
                "téglalap",
                "háromszög",
                "Négyzet"
            };
            return sokszogek;
        }
    }
}
