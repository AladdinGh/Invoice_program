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
    public partial class Artikel_anschauen_form : Form
    {

        Form parent;


        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;


        private Artikel_hinfügen artikel_hinfügen;
        public Artikel_anschauen_form(Form parent)
        {
            this.parent = parent; 
            InitializeComponent();
        }

        private void zurück_Click(object sender, EventArgs e)
        {
            this.parent.Visible = true;
            this.Hide();
        }

        private void Artikel_anschauen_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit(); 
        }

        private void Add_artikel_Click(object sender, EventArgs e)
        {
            try
            {

                artikel_hinfügen = new Artikel_hinfügen(this);
                artikel_hinfügen.Show(this); // the "this" is important, as this will keep Form2 open above 

                this.Visible = false;
                //this.Close(); 
            
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Bitte ein artikel wählen und ein richtige preis und einheit geben");
            }
        }

        private void delete_artikel_Click(object sender, EventArgs e)
        {

            try
            {
                var indexRow = this.itemsDataGridView.CurrentRow.Index;
                var item_id = this.itemsDataGridView.Rows[indexRow].Cells[0].Value;
                //string indexRow = this.itemsDataGridView.Rows[itemsDataGridView.CurrentRow.Index].Cells[0].Value.ToString();
                //MessageBox.Show(item_id.ToString());
                //var ts = this.itemsDataGridView.SelectedRows[0].Index; 

                // if (indexRow.Value != DBNull.Value) 
                //{

                con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\galaeddine\Documents\visual studio 2013\Projects\LouisPartyService\LouisPartyService\mydb.mdf;Integrated Security=True");


                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Items WHERE Id_item = @Id_item", con);
                cmd.Parameters.Add("@Id_item", Convert.ToInt16(item_id));

                cmd.ExecuteNonQuery();
                
                da = new SqlDataAdapter("SELECT * FROM items", con);
                DataTable dttb = new DataTable();
                da.Fill(dttb);
                this.itemsDataGridView.DataSource = dttb;

                cmd.ExecuteNonQuery();
                con.Close();
                //this.itemsDataGridView.SelectedRows[0].Index
                
                //}

            }
            catch (Exception Ex) { MessageBox.Show("Liste leer"); }

            // delete it from the data grid 
            /*try
            {
                this.itemsDataGridView.Rows.RemoveAt(this.itemsDataGridView.SelectedRows[0].Index);

            }
            catch (Exception Ex1)
            {
                Int32 index = itemsDataGridView.Rows.Count - 1;
                try
                {
                    this.itemsDataGridView.Rows.RemoveAt(index - 1);
                }
                catch (Exception Ex2)
                //{ MessageBox.Show("zum löschen, Bitte ein artikel wählen"); }
                { MessageBox.Show("Liste leer"); }
            }*/
           

        }

        private void Artikel_anschauen_form_Load(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter.FillBy(this.mydbDataSet.Items);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
          
           // this.itemsBindingSource.EndEdit();

            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\galaeddine\Documents\visual studio 2013\Projects\LouisPartyService\LouisPartyService\mydb.mdf;Integrated Security=True");
            con.Open();
            //MessageBox.Show("connection succeeded"); 
            da = new SqlDataAdapter("SELECT * FROM items", con);
            DataTable dttb = new DataTable();
            da.Fill(dttb);
            this.itemsDataGridView.DataSource = dttb;

            //cmd.ExecuteNonQuery();
            con.Close();
        }


     
    }
}
