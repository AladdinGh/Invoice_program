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
    public partial class Rechnung_anschauen_form : Form
    {

        Form parent;
        public Rechnung_anschauen_form(Form parent)
        {
            this.parent = parent; 
            InitializeComponent();
        }



        private void Rechnung_anschauen_form_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "mydbDataSet.Invoice". Sie können sie bei Bedarf verschieben oder entfernen.
            this.invoiceTableAdapter.Fill(this.mydbDataSet.Invoice);

        }

        private void Rechnung_anschauen_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit(); 
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.invoiceTableAdapter.FillBy(this.mydbDataSet.Invoice);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var value = Rechnungen_liste.Rows[e.RowIndex].Cells[0].Value.ToString();
            System.Windows.Forms.MessageBox.Show(value);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.parent.Visible = true;
            this.Hide();
        }

        

        
    }
}
