namespace GSB {
    partial class FrmConsultationVisite {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvVisite = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEchantillons = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.BilanBox = new System.Windows.Forms.TextBox();
            this.leMotif = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lePraticien = new System.Windows.Forms.Label();
            this.laRue = new System.Windows.Forms.Label();
            this.leTelephone = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.leTypePraticien = new System.Windows.Forms.Label();
            this.laSpecialite = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listMedicaments = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEchantillons)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Size = new System.Drawing.Size(864, 64);
            // 
            // dgvVisite
            // 
            this.dgvVisite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisite.Location = new System.Drawing.Point(7, 121);
            this.dgvVisite.Name = "dgvVisite";
            this.dgvVisite.Size = new System.Drawing.Size(314, 286);
            this.dgvVisite.TabIndex = 13;
            this.dgvVisite.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisite_CellClick);
            this.dgvVisite.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisite_CellContentClick);
            this.dgvVisite.SelectionChanged += new System.EventHandler(this.dgvVisite_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sélectionner la visite pour afficher le détail";
            // 
            // dgvEchantillons
            // 
            this.dgvEchantillons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEchantillons.Location = new System.Drawing.Point(333, 17);
            this.dgvEchantillons.Name = "dgvEchantillons";
            this.dgvEchantillons.Size = new System.Drawing.Size(189, 154);
            this.dgvEchantillons.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Médicaments présentés";
            // 
            // BilanBox
            // 
            this.BilanBox.Location = new System.Drawing.Point(13, 39);
            this.BilanBox.Multiline = true;
            this.BilanBox.Name = "BilanBox";
            this.BilanBox.Size = new System.Drawing.Size(272, 57);
            this.BilanBox.TabIndex = 17;
            // 
            // leMotif
            // 
            this.leMotif.AutoSize = true;
            this.leMotif.Location = new System.Drawing.Point(91, 1);
            this.leMotif.Name = "leMotif";
            this.leMotif.Size = new System.Drawing.Size(38, 13);
            this.leMotif.TabIndex = 16;
            this.leMotif.Text = "leMotif";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(338, 1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Echantillons fournis";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Bilan de la visite";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Motif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Praticien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Téléphone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // lePraticien
            // 
            this.lePraticien.AutoSize = true;
            this.lePraticien.Location = new System.Drawing.Point(91, 16);
            this.lePraticien.Name = "lePraticien";
            this.lePraticien.Size = new System.Drawing.Size(56, 13);
            this.lePraticien.TabIndex = 4;
            this.lePraticien.Text = "lePraticien";
            // 
            // laRue
            // 
            this.laRue.AutoSize = true;
            this.laRue.Location = new System.Drawing.Point(91, 39);
            this.laRue.Name = "laRue";
            this.laRue.Size = new System.Drawing.Size(35, 13);
            this.laRue.TabIndex = 5;
            this.laRue.Text = "laRue";
            // 
            // leTelephone
            // 
            this.leTelephone.AutoSize = true;
            this.leTelephone.Location = new System.Drawing.Point(91, 62);
            this.leTelephone.Name = "leTelephone";
            this.leTelephone.Size = new System.Drawing.Size(66, 13);
            this.leTelephone.TabIndex = 6;
            this.leTelephone.Text = "leTelephone";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Location = new System.Drawing.Point(91, 84);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(25, 13);
            this.mail.TabIndex = 7;
            this.mail.Text = "mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Type praticien";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Spécialité";
            // 
            // leTypePraticien
            // 
            this.leTypePraticien.AutoSize = true;
            this.leTypePraticien.Location = new System.Drawing.Point(338, 16);
            this.leTypePraticien.Name = "leTypePraticien";
            this.leTypePraticien.Size = new System.Drawing.Size(80, 13);
            this.leTypePraticien.TabIndex = 10;
            this.leTypePraticien.Text = "leTypePraticien";
            // 
            // laSpecialite
            // 
            this.laSpecialite.AutoSize = true;
            this.laSpecialite.Location = new System.Drawing.Point(338, 62);
            this.laSpecialite.Name = "laSpecialite";
            this.laSpecialite.Size = new System.Drawing.Size(61, 13);
            this.laSpecialite.TabIndex = 11;
            this.laSpecialite.Text = "laSpecialite";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.laSpecialite);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lePraticien);
            this.panel2.Controls.Add(this.laRue);
            this.panel2.Controls.Add(this.leTypePraticien);
            this.panel2.Controls.Add(this.leTelephone);
            this.panel2.Controls.Add(this.mail);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(327, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 107);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listMedicaments);
            this.panel3.Controls.Add(this.dgvEchantillons);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.leMotif);
            this.panel3.Controls.Add(this.BilanBox);
            this.panel3.Location = new System.Drawing.Point(327, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 176);
            this.panel3.TabIndex = 22;
            // 
            // listMedicaments
            // 
            this.listMedicaments.FormattingEnabled = true;
            this.listMedicaments.Location = new System.Drawing.Point(13, 115);
            this.listMedicaments.Name = "listMedicaments";
            this.listMedicaments.Size = new System.Drawing.Size(272, 56);
            this.listMedicaments.TabIndex = 21;
            // 
            // FrmConsultationVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVisite);
            this.Name = "FrmConsultationVisite";
            this.Text = "FrmConsultationVisite";
            this.Load += new System.EventHandler(this.FrmConsultationVisite_Load);
            this.Controls.SetChildIndex(this.dgvVisite, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEchantillons)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BilanBox;
        private System.Windows.Forms.Label leMotif;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvEchantillons;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lePraticien;
        private System.Windows.Forms.Label laRue;
        private System.Windows.Forms.Label leTelephone;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label leTypePraticien;
        private System.Windows.Forms.Label laSpecialite;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listMedicaments;
    }
}