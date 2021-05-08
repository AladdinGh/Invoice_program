using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LouisPartyService
{
    public partial class Main_window : Form
    {
        public Main_window()
        {
            InitializeComponent();
        }


        private Rechnung_hinfügen_form rechnung_hinfügen_form;
        private Artikel_anschauen_form artikel_amschauen_form;
        private Rechnung_anschauen_form rechnungen_form;

        private void Rechnunghinfügen_Click(object sender, EventArgs e)
        {
            rechnung_hinfügen_form = new Rechnung_hinfügen_form(this);
            rechnung_hinfügen_form.Show(this); // the "this" is important, as this will keep Form2 open above 
            
            this.Visible = false;
        }

        private void Rechnungladen_Click(object sender, EventArgs e)
        {
            // TO DO : show list of invoices and let the client choose one 
            rechnungen_form = new Rechnung_anschauen_form(this);
            rechnungen_form.Show(this); // the "this" is important, as this will keep Form2 open above 

            this.Visible = false;

        }

        private void Artikelanschauenn_Click(object sender, EventArgs e)
        {
            artikel_amschauen_form = new Artikel_anschauen_form(this);
            artikel_amschauen_form.Show(this); // the "this" is important, as this will keep Form2 open above 

            this.Visible = false;
        }

    

    }
}
