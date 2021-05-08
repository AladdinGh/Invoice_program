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
    public partial class Artikel_hinfügen : Form
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        
        Artikel_anschauen_form parent;
        public Artikel_hinfügen(Artikel_anschauen_form parent)
        {
            this.parent = parent; 
            InitializeComponent();
        }

        private void Artikel_hinfügen_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\galaeddine\Documents\visual studio 2013\Projects\LouisPartyService\LouisPartyService\mydb.mdf;Integrated Security=True");
                con.Open();
                //MessageBox.Show("connection succeeded"); 
                cmd = new SqlCommand("INSERT INTO items (Id_item,name,Einheit,preis_pro_einheit) VALUES (@ID,@name,@Einheit,@preis_pro_einheit)", con);

                cmd.Parameters.Add("@ID", this.id_itemTextBox.Text);
                cmd.Parameters.Add("@name", this.nameTextBox.Text);
                cmd.Parameters.Add("@Einheit", this.EinheitList.SelectedItem.ToString());
                cmd.Parameters.Add("@preis_pro_einheit", this.preis_pro_einheitTextBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                // go back to the parent form
                this.parent.Visible = true;
                //this.parent.Show(this);
                this.Hide();
                
            }
            catch (Exception ex) { MessageBox.Show("Bitte eine neue Artikel geben"); }
            
        
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.parent.Visible = true;
            //this.parent.Show(this);
            this.Hide();
        }
    }
}
