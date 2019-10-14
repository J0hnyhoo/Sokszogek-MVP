using Sokszogek_MVP.Repositories;
using Sokszogek_MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek_MVP.Presenters
{
    public class SokszogPresenter
    {
        private ISokszogView SokszogView;
        private ISokszogRepository sokszogRepo;

        public SokszogPresenter(ISokszogView sokszogV)
        {
            SokszogView = sokszogV;
            sokszogRepo = new SokszogRepository();
        }
        public void LoadData()
        {
            SokszogView.SokszogList = sokszogRepo.GetSokSzogek();
        }
    }
}
