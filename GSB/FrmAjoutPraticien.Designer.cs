namespace GSB {
    partial class FrmAjoutPraticien {
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.AjoutBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.villeBox = new System.Windows.Forms.TextBox();
            this.speBox = new System.Windows.Forms.ComboBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.telBox = new System.Windows.Forms.TextBox();
            this.rueBox = new System.Windows.Forms.TextBox();
            this.prenomBox = new System.Windows.Forms.TextBox();
            this.nomBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Size = new System.Drawing.Size(800, 64);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AjoutBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.villeBox);
            this.panel2.Controls.Add(this.speBox);
            this.panel2.Controls.Add(this.typeBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.mailBox);
            this.panel2.Controls.Add(this.telBox);
            this.panel2.Controls.Add(this.rueBox);
            this.panel2.Controls.Add(this.prenomBox);
            this.panel2.Controls.Add(this.nomBox);
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 314);
            this.panel2.TabIndex = 13;
            // 
            // AjoutBtn
            // 
            this.AjoutBtn.BackColor = System.Drawing.Color.Red;
            this.AjoutBtn.Location = new System.Drawing.Point(257, 271);
            this.AjoutBtn.Name = "AjoutBtn";
            this.AjoutBtn.Size = new System.Drawing.Size(93, 28);
            this.AjoutBtn.TabIndex = 19;
            this.AjoutBtn.Text = "Ajouter";
            this.AjoutBtn.UseVisualStyleBackColor = false;
            this.AjoutBtn.Click += new System.EventHandler(this.AjoutBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Adresse E-mail";
            // 
            // villeBox
            // 
            this.villeBox.Location = new System.Drawing.Point(63, 122);
            this.villeBox.Name = "villeBox";
            this.villeBox.Size = new System.Drawing.Size(540, 20);
            this.villeBox.TabIndex = 16;
            // 
            // speBox
            // 
            this.speBox.FormattingEnabled = true;
            this.speBox.Location = new System.Drawing.Point(363, 244);
            this.speBox.Name = "speBox";
            this.speBox.Size = new System.Drawing.Size(240, 21);
            this.speBox.TabIndex = 15;
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(25, 244);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(219, 21);
            this.typeBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Spécialité";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Téléphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ville";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom";
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(363, 180);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(240, 20);
            this.mailBox.TabIndex = 5;
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(25, 180);
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(219, 20);
            this.telBox.TabIndex = 4;
            // 
            // rueBox
            // 
            this.rueBox.Location = new System.Drawing.Point(25, 82);
            this.rueBox.Name = "rueBox";
            this.rueBox.Size = new System.Drawing.Size(578, 20);
            this.rueBox.TabIndex = 2;
            // 
            // prenomBox
            // 
            this.prenomBox.Location = new System.Drawing.Point(363, 32);
            this.prenomBox.Name = "prenomBox";
            this.prenomBox.Size = new System.Drawing.Size(240, 20);
            this.prenomBox.TabIndex = 1;
            // 
            // nomBox
            // 
            this.nomBox.Location = new System.Drawing.Point(25, 32);
            this.nomBox.Name = "nomBox";
            this.nomBox.Size = new System.Drawing.Size(219, 20);
            this.nomBox.TabIndex = 0;
            // 
            // FrmAjoutPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "FrmAjoutPraticien";
            this.Text = "FrmAjoutPraticien";
            this.Load += new System.EventHandler(this.FrmAjoutPraticien_Load);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.TextBox telBox;
        private System.Windows.Forms.TextBox rueBox;
        private System.Windows.Forms.TextBox prenomBox;
        private System.Windows.Forms.TextBox nomBox;
        private System.Windows.Forms.TextBox villeBox;
        private System.Windows.Forms.ComboBox speBox;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AjoutBtn;
        private System.Windows.Forms.Label label7;
    }
}