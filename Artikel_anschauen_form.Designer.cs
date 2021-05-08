namespace LouisPartyService
{
    partial class Artikel_anschauen_form
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
            this.Add_artikel = new System.Windows.Forms.Button();
            this.delete_artikel = new System.Windows.Forms.Button();
            this.zurück = new System.Windows.Forms.Button();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet = new LouisPartyService.mydbDataSet();
            this.itemsTableAdapter = new LouisPartyService.mydbDataSetTableAdapters.ItemsTableAdapter();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new LouisPartyService.mydbDataSetTableAdapters.InvoiceTableAdapter();
            this.tableAdapterManager = new LouisPartyService.mydbDataSetTableAdapters.TableAdapterManager();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_artikel
            // 
            this.Add_artikel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_artikel.Location = new System.Drawing.Point(523, 141);
            this.Add_artikel.Name = "Add_artikel";
            this.Add_artikel.Size = new System.Drawing.Size(75, 47);
            this.Add_artikel.TabIndex = 7;
            this.Add_artikel.Text = "Artikel hinfügen";
            this.Add_artikel.UseVisualStyleBackColor = true;
            this.Add_artikel.Click += new System.EventHandler(this.Add_artikel_Click);
            // 
            // delete_artikel
            // 
            this.delete_artikel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_artikel.Location = new System.Drawing.Point(523, 210);
            this.delete_artikel.Name = "delete_artikel";
            this.delete_artikel.Size = new System.Drawing.Size(75, 43);
            this.delete_artikel.TabIndex = 8;
            this.delete_artikel.Text = "Artikel entfernen";
            this.delete_artikel.UseVisualStyleBackColor = true;
            this.delete_artikel.Click += new System.EventHandler(this.delete_artikel_Click);
            // 
            // zurück
            // 
            this.zurück.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zurück.Location = new System.Drawing.Point(533, 442);
            this.zurück.Name = "zurück";
            this.zurück.Size = new System.Drawing.Size(75, 24);
            this.zurück.TabIndex = 9;
            this.zurück.Text = "Zurück";
            this.zurück.UseVisualStyleBackColor = true;
            this.zurück.Click += new System.EventHandler(this.zurück_Click);
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
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.mydbDataSet;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InvoiceTableAdapter = this.invoiceTableAdapter;
            this.tableAdapterManager.ItemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.UpdateOrder = LouisPartyService.mydbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itemsDataGridView.AutoGenerateColumns = false;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.itemsDataGridView.DataSource = this.itemsBindingSource;
            this.itemsDataGridView.Location = new System.Drawing.Point(15, 12);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.Size = new System.Drawing.Size(446, 471);
            this.itemsDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_item";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Einheit";
            this.dataGridViewTextBoxColumn3.HeaderText = "Einheit";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "preis_pro_einheit";
            this.dataGridViewTextBoxColumn4.HeaderText = "preis_pro_einheit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Artikel_anschauen_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.itemsDataGridView);
            this.Controls.Add(this.zurück);
            this.Controls.Add(this.delete_artikel);
            this.Controls.Add(this.Add_artikel);
            this.Name = "Artikel_anschauen_form";
            this.Text = "Liste des artikeln";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Artikel_anschauen_form_FormClosed);
            this.Load += new System.EventHandler(this.Artikel_anschauen_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private mydbDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.Button Add_artikel;
        private System.Windows.Forms.Button delete_artikel;
        private System.Windows.Forms.Button zurück;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private mydbDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private mydbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
    }
}