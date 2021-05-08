namespace LouisPartyService
{
    partial class Rechnung_hinfügen_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rechnung_hinfügen_form));
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Rechnungnummer_value = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet = new LouisPartyService.mydbDataSet();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Zurück_zum_haupt = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.itemsTableAdapter = new LouisPartyService.mydbDataSetTableAdapters.ItemsTableAdapter();
            this.tableAdapterManager = new LouisPartyService.mydbDataSetTableAdapters.TableAdapterManager();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Produkt = new System.Windows.Forms.ComboBox();
            this.PreisProdukt = new System.Windows.Forms.TextBox();
            this.menge = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rechnungspeichern = new System.Windows.Forms.Button();
            this.rechnungdrucken = new System.Windows.Forms.Button();
            this.listartikeln = new System.Windows.Forms.DataGridView();
            this.prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.artikelentfernen = new System.Windows.Forms.Button();
            this.artikelhinfugen = new System.Windows.Forms.Button();
            this.Einheit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.items_group = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSetBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listartikeln)).BeginInit();
            this.items_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(25, 88);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(209, 87);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "Herrn Max Mustermann\nMusterstr ,1235 Musterstadt\nDeutschland";
            // 
            // Rechnungnummer_value
            // 
            this.Rechnungnummer_value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rechnungnummer_value.Location = new System.Drawing.Point(108, 75);
            this.Rechnungnummer_value.Name = "Rechnungnummer_value";
            this.Rechnungnummer_value.Size = new System.Drawing.Size(242, 20);
            this.Rechnungnummer_value.TabIndex = 14;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(25, -1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(262, 83);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "Louis Party Service\nHohenstaufenstr. 56, 75177 Pforzheim\n072311829182 | Mobil : 0" +
    "1793610036\nwww.louis-partyservice.de\n";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Rechnungnummer_value, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(353, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 110);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(5, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 38);
            this.label3.TabIndex = 20;
            this.label3.Text = "Rechnung nummer";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(64, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Datum";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.mydbDataSet;
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "Items";
            this.itemsBindingSource1.DataSource = this.mydbDataSetBindingSource;
            // 
            // mydbDataSetBindingSource
            // 
            this.mydbDataSetBindingSource.DataSource = this.mydbDataSet;
            this.mydbDataSetBindingSource.Position = 0;
            // 
            // Zurück_zum_haupt
            // 
            this.Zurück_zum_haupt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Zurück_zum_haupt.Location = new System.Drawing.Point(646, 850);
            this.Zurück_zum_haupt.Name = "Zurück_zum_haupt";
            this.Zurück_zum_haupt.Size = new System.Drawing.Size(95, 33);
            this.Zurück_zum_haupt.TabIndex = 18;
            this.Zurück_zum_haupt.Text = "Zurück";
            this.Zurück_zum_haupt.UseVisualStyleBackColor = true;
            this.Zurück_zum_haupt.Click += new System.EventHandler(this.Zurück_zum_haupt_Click_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.UpdateOrder = LouisPartyService.mydbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Produkt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Preis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Menge";
            // 
            // Produkt
            // 
            this.Produkt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Produkt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Produkt.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "name", true));
            this.Produkt.DataSource = this.itemsBindingSource1;
            this.Produkt.DisplayMember = "name";
            this.Produkt.FormattingEnabled = true;
            this.Produkt.Location = new System.Drawing.Point(57, 29);
            this.Produkt.Name = "Produkt";
            this.Produkt.Size = new System.Drawing.Size(121, 21);
            this.Produkt.TabIndex = 3;
            this.Produkt.ValueMember = "Id_item";
            this.Produkt.SelectedIndexChanged += new System.EventHandler(this.Produkt_SelectedIndexChanged);
            // 
            // PreisProdukt
            // 
            this.PreisProdukt.Location = new System.Drawing.Point(227, 29);
            this.PreisProdukt.Name = "PreisProdukt";
            this.PreisProdukt.Size = new System.Drawing.Size(100, 20);
            this.PreisProdukt.TabIndex = 4;
            // 
            // menge
            // 
            this.menge.Location = new System.Drawing.Point(560, 29);
            this.menge.Multiline = true;
            this.menge.Name = "menge";
            this.menge.Size = new System.Drawing.Size(100, 21);
            this.menge.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.rechnungspeichern, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rechnungdrucken, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(395, 85);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(180, 43);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // rechnungspeichern
            // 
            this.rechnungspeichern.Location = new System.Drawing.Point(93, 3);
            this.rechnungspeichern.Name = "rechnungspeichern";
            this.rechnungspeichern.Size = new System.Drawing.Size(76, 37);
            this.rechnungspeichern.TabIndex = 11;
            this.rechnungspeichern.Text = "Speichern";
            this.rechnungspeichern.UseVisualStyleBackColor = true;
            this.rechnungspeichern.Click += new System.EventHandler(this.rechnungspeichern_Click);
            // 
            // rechnungdrucken
            // 
            this.rechnungdrucken.Location = new System.Drawing.Point(3, 3);
            this.rechnungdrucken.Name = "rechnungdrucken";
            this.rechnungdrucken.Size = new System.Drawing.Size(76, 37);
            this.rechnungdrucken.TabIndex = 10;
            this.rechnungdrucken.Text = "Drucken";
            this.rechnungdrucken.UseVisualStyleBackColor = true;
            this.rechnungdrucken.Click += new System.EventHandler(this.rechnungdrucken_Click);
            // 
            // listartikeln
            // 
            this.listartikeln.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listartikeln.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prod,
            this.meng,
            this.price});
            this.listartikeln.Location = new System.Drawing.Point(25, 153);
            this.listartikeln.Name = "listartikeln";
            this.listartikeln.Size = new System.Drawing.Size(534, 378);
            this.listartikeln.TabIndex = 13;
            // 
            // prod
            // 
            this.prod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prod.HeaderText = "Produkt";
            this.prod.Name = "prod";
            // 
            // meng
            // 
            this.meng.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.meng.HeaderText = "Menge";
            this.meng.Name = "meng";
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "Preis insgesamt";
            this.price.Name = "price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hinzugefügte Artikeln";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(340, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Einheit";
            // 
            // artikelentfernen
            // 
            this.artikelentfernen.Location = new System.Drawing.Point(584, 320);
            this.artikelentfernen.Name = "artikelentfernen";
            this.artikelentfernen.Size = new System.Drawing.Size(76, 37);
            this.artikelentfernen.TabIndex = 17;
            this.artikelentfernen.Text = "Enternen";
            this.artikelentfernen.UseVisualStyleBackColor = true;
            this.artikelentfernen.Click += new System.EventHandler(this.artikelentfernen_Click_1);
            // 
            // artikelhinfugen
            // 
            this.artikelhinfugen.Location = new System.Drawing.Point(584, 244);
            this.artikelhinfugen.Name = "artikelhinfugen";
            this.artikelhinfugen.Size = new System.Drawing.Size(76, 37);
            this.artikelhinfugen.TabIndex = 8;
            this.artikelhinfugen.Text = "Hinfügen";
            this.artikelhinfugen.UseVisualStyleBackColor = true;
            this.artikelhinfugen.Click += new System.EventHandler(this.artikelhinfugen_Click);
            // 
            // Einheit
            // 
            this.Einheit.FormattingEnabled = true;
            this.Einheit.Location = new System.Drawing.Point(395, 29);
            this.Einheit.Name = "Einheit";
            this.Einheit.Size = new System.Drawing.Size(79, 21);
            this.Einheit.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 575);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Rechnung Total";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(459, 572);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 20;
            // 
            // items_group
            // 
            this.items_group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.items_group.Controls.Add(this.textBox3);
            this.items_group.Controls.Add(this.label7);
            this.items_group.Controls.Add(this.Einheit);
            this.items_group.Controls.Add(this.artikelhinfugen);
            this.items_group.Controls.Add(this.artikelentfernen);
            this.items_group.Controls.Add(this.label9);
            this.items_group.Controls.Add(this.label8);
            this.items_group.Controls.Add(this.listartikeln);
            this.items_group.Controls.Add(this.tableLayoutPanel2);
            this.items_group.Controls.Add(this.menge);
            this.items_group.Controls.Add(this.PreisProdukt);
            this.items_group.Controls.Add(this.Produkt);
            this.items_group.Controls.Add(this.label6);
            this.items_group.Controls.Add(this.label5);
            this.items_group.Controls.Add(this.label4);
            this.items_group.Location = new System.Drawing.Point(25, 193);
            this.items_group.Name = "items_group";
            this.items_group.Size = new System.Drawing.Size(716, 642);
            this.items_group.TabIndex = 17;
            this.items_group.TabStop = false;
            this.items_group.Text = "Rechnung";
            // 
            // Rechnung_hinfügen_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 873);
            this.Controls.Add(this.Zurück_zum_haupt);
            this.Controls.Add(this.items_group);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTextBox2);
            this.Name = "Rechnung_hinfügen_form";
            this.Text = "Rechnung hinfügen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rechnung_hinfügen_form_FormClosed);
            this.Load += new System.EventHandler(this.Rechnung_hinfügen_form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSetBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listartikeln)).EndInit();
            this.items_group.ResumeLayout(false);
            this.items_group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox Rechnungnummer_value;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Zurück_zum_haupt;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private mydbDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private mydbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource mydbDataSetBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Produkt;
        private System.Windows.Forms.TextBox PreisProdukt;
        private System.Windows.Forms.TextBox menge;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button rechnungspeichern;
        private System.Windows.Forms.Button rechnungdrucken;
        private System.Windows.Forms.DataGridView listartikeln;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn meng;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button artikelentfernen;
        private System.Windows.Forms.Button artikelhinfugen;
        private System.Windows.Forms.ComboBox Einheit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox items_group;



    }
}