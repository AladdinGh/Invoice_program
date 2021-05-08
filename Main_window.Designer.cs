namespace LouisPartyService
{
    partial class Main_window
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Rechnungladen = new System.Windows.Forms.Button();
            this.Artikelanschauenn = new System.Windows.Forms.Button();
            this.Rechnunghinfügen = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Rechnungladen, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Artikelanschauenn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Rechnunghinfügen, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(102, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(476, 175);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Rechnungladen
            // 
            this.Rechnungladen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rechnungladen.Location = new System.Drawing.Point(3, 90);
            this.Rechnungladen.Name = "Rechnungladen";
            this.Rechnungladen.Size = new System.Drawing.Size(232, 82);
            this.Rechnungladen.TabIndex = 6;
            this.Rechnungladen.Text = "Rechnung laden";
            this.Rechnungladen.UseVisualStyleBackColor = true;
            this.Rechnungladen.Click += new System.EventHandler(this.Rechnungladen_Click);
            // 
            // Artikelanschauenn
            // 
            this.Artikelanschauenn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Artikelanschauenn.Location = new System.Drawing.Point(241, 90);
            this.Artikelanschauenn.Name = "Artikelanschauenn";
            this.Artikelanschauenn.Size = new System.Drawing.Size(232, 82);
            this.Artikelanschauenn.TabIndex = 5;
            this.Artikelanschauenn.Text = "Artikel anschauen";
            this.Artikelanschauenn.UseVisualStyleBackColor = true;
            this.Artikelanschauenn.Click += new System.EventHandler(this.Artikelanschauenn_Click);
            // 
            // Rechnunghinfügen
            // 
            this.Rechnunghinfügen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rechnunghinfügen.Location = new System.Drawing.Point(3, 3);
            this.Rechnunghinfügen.Name = "Rechnunghinfügen";
            this.Rechnunghinfügen.Size = new System.Drawing.Size(232, 81);
            this.Rechnunghinfügen.TabIndex = 1;
            this.Rechnunghinfügen.Text = "Rechnung hinfügen";
            this.Rechnunghinfügen.UseVisualStyleBackColor = true;
            this.Rechnunghinfügen.Click += new System.EventHandler(this.Rechnunghinfügen_Click);
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(717, 321);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main_window";
            this.Text = "Louis Party Service";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Artikelanschauenn;
        private System.Windows.Forms.Button Rechnunghinfügen;
        private System.Windows.Forms.Button Rechnungladen;
    }
}

