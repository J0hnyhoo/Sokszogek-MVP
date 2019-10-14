using Sokszogek_MVP.Presenters;
using Sokszogek_MVP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokszogek_MVP
{
    public partial class Form1 : Form, ISokszogView
    {
        private SokszogPresenter presenter;
        public Form1()
        {
            presenter = new SokszogPresenter(this);
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        public string oldalA
        {
            get => OldalA.Text;
            set => OldalA.Text=value;
        }
        public string oldalB
        {
            get => OldalB.Text;
            set => OldalB.Text=value;
        }
        public string Kerulet
        {
            get => TextboxKerulet.Text;
            set => TextboxKerulet.Text=value;
        }
        public string Terulet
        {
            get =>TeruletTextbox.Text;
            set =>TeruletTextbox.Text=value;
        }
        public IList<string> SokszogList
        {
            get =>(List<string>)Sokszog.DataSource;
            set => Sokszog.DataSource=value;
        }
    }
}
