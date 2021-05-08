using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace LouisPartyService
{
    public partial class Rechnung_hinfügen_form : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        Form parent;


        public Rechnung_hinfügen_form(Form parent)
        {
            this.parent = parent; 
            InitializeComponent();
        }


        private void Rechnung_hinfügen_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit(); 
        }

      


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);

        }

        Bitmap bitmap; 
        private void rechnungdrucken_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog(); 

        }


        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        private void rechnungspeichern_Click(object sender, EventArgs e)
        {
            // TO DO : Save the invoice in the database

            string str = RandomString(20);
            this.Rechnungnummer_value.Text = str;
            
            
            DataRowView rowView = (DataRowView)this.Produkt.SelectedItem;
            string id_item;

            //if (rowView != null)
            //{
            id_item = rowView["Id_item"].ToString();

            //}
            
            //try
            //{
                con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\galaeddine\Documents\visual studio 2013\Projects\LouisPartyService\LouisPartyService\mydb.mdf;Integrated Security=True");
                con.Open();
                //MessageBox.Show("connection succeeded"); 
                cmd = new SqlCommand("INSERT INTO Invoice (Id_inv,Id_art,client,date,Qte_item,Rechnungs_nummer) VALUES (@Id_inv,@Id_art,@client,@date,@Qte_item,@Rechnungs_nummer)", con);
                
                
              


                cmd.Parameters.Add("@Id_inv", 11);
                cmd.Parameters.Add("@Id_art", id_item);
                cmd.Parameters.Add("@client", this.richTextBox2.Text);
                cmd.Parameters.Add("@date", this.dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.Add("@Qte_item", this.menge.Text);
                cmd.Parameters.Add("@Rechnungs_nummer", this.Rechnungnummer_value.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                // go back to the parent form
                //this.parent.Visible = true;
                //this.parent.Show(this);
                //this.Hide();

            //}
            //catch (Exception ex) { MessageBox.Show("Bitte eine neue Artikel geben"); }
            

        }



        private void artikelentfernen_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.listartikeln.Rows.RemoveAt(this.listartikeln.SelectedRows[0].Index);

            }
            catch (Exception Ex1)
            {
                Int32 index = listartikeln.Rows.Count - 1;
                try
                {
                    this.listartikeln.Rows.RemoveAt(index - 1);
                }
                catch (Exception Ex2)
                //{ MessageBox.Show("zum löschen, Bitte ein artikel wählen"); }
                { MessageBox.Show("Liste leer"); }

            }
        }

        private void Zurück_zum_haupt_Click_1(object sender, EventArgs e)
        {
            this.parent.Visible = true;
            this.Hide();
        }

        private void artikelhinfugen_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView rowView = (DataRowView)this.Produkt.SelectedItem;

                if (rowView != null)
                {
                    string artikelname = rowView["name"].ToString();
                    string artikelmenge = this.menge.Text;
                    string artikelpreis = this.PreisProdukt.Text;
                    this.listartikeln.Rows.Add(artikelname, artikelmenge, float.Parse(artikelpreis) * float.Parse(artikelmenge));
                }
              
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Bitte ein artikel wählen und ein richtige preis und Menge geben");
            }
        }


        private void Rechnung_hinfügen_form_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "mydbDataSet.Invoice". Sie können sie bei Bedarf verschieben oder entfernen.
            //this.invoiceTableAdapter.Fill(this.mydbDataSet.Invoice);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "mydbDataSet.Items". Sie können sie bei Bedarf verschieben oder entfernen.
            this.itemsTableAdapter.Fill(this.mydbDataSet.Items);

        }

        private void Produkt_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView rowView = (DataRowView)this.Produkt.SelectedItem;

            if (rowView != null)
            {
                
                this.Einheit.Text = rowView["Einheit"].ToString();
                this.PreisProdukt.Text = rowView["preis_pro_einheit"].ToString(); 
            }
        }


       
      


        

        

     

       
        
     

    }
}
