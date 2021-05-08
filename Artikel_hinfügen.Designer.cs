namespace LouisPartyService
{
    partial class Artikel_hinfügen
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
            System.Windows.Forms.Label id_itemLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label einheitLabel;
            System.Windows.Forms.Label preis_pro_einheitLabel;
            this.id_itemTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.preis_pro_einheitTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EinheitList = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            id_itemLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            einheitLabel = new System.Windows.Forms.Label();
            preis_pro_einheitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id_itemLabel
            // 
            id_itemLabel.AutoSize = true;
            id_itemLabel.Location = new System.Drawing.Point(57, 65);
            id_itemLabel.Name = "id_itemLabel";
            id_itemLabel.Size = new System.Drawing.Size(41, 13);
            id_itemLabel.TabIndex = 24;
            id_itemLabel.Text = "Id item:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(57, 91);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 26;
            nameLabel.Text = "name:";
            // 
            // einheitLabel
            // 
            einheitLabel.AutoSize = true;
            einheitLabel.Location = new System.Drawing.Point(57, 117);
            einheitLabel.Name = "einheitLabel";
            einheitLabel.Size = new System.Drawing.Size(42, 13);
            einheitLabel.TabIndex = 28;
            einheitLabel.Text = "Einheit:";
            // 
            // preis_pro_einheitLabel
            // 
            preis_pro_einheitLabel.AutoSize = true;
            preis_pro_einheitLabel.Location = new System.Drawing.Point(57, 143);
            preis_pro_einheitLabel.Name = "preis_pro_einheitLabel";
            preis_pro_einheitLabel.Size = new System.Drawing.Size(84, 13);
            preis_pro_einheitLabel.TabIndex = 30;
            preis_pro_einheitLabel.Text = "preis pro einheit:";
            // 
            // id_itemTextBox
            // 
            this.id_itemTextBox.Location = new System.Drawing.Point(147, 62);
            this.id_itemTextBox.Name = "id_itemTextBox";
            this.id_itemTextBox.Size = new System.Drawing.Size(143, 20);
            this.id_itemTextBox.TabIndex = 25;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(147, 88);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(143, 20);
            this.nameTextBox.TabIndex = 27;
            // 
            // preis_pro_einheitTextBox
            // 
            this.preis_pro_einheitTextBox.Location = new System.Drawing.Point(147, 140);
            this.preis_pro_einheitTextBox.Name = "preis_pro_einheitTextBox";
            this.preis_pro_einheitTextBox.Size = new System.Drawing.Size(143, 20);
            this.preis_pro_einheitTextBox.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Hinfügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EinheitList
            // 
            this.EinheitList.FormattingEnabled = true;
            this.EinheitList.Items.AddRange(new object[] {
            "kg",
            "kiste",
            "packet",
            "stück"});
            this.EinheitList.Location = new System.Drawing.Point(147, 113);
            this.EinheitList.Name = "EinheitList";
            this.EinheitList.Size = new System.Drawing.Size(121, 21);
            this.EinheitList.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Zurück";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Artikel_hinfügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 269);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EinheitList);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_itemLabel);
            this.Controls.Add(this.id_itemTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(einheitLabel);
            this.Controls.Add(preis_pro_einheitLabel);
            this.Controls.Add(this.preis_pro_einheitTextBox);
            this.Name = "Artikel_hinfügen";
            this.Text = "Artikel_hinfügen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Artikel_hinfügen_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_itemTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox preis_pro_einheitTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox EinheitList;
        private System.Windows.Forms.Button button2;

    }
}