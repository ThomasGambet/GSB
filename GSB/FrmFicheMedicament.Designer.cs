namespace GSB {
    partial class FrmFicheMedicament {
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListeMedicamentBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ContreIndicationBox = new System.Windows.Forms.TextBox();
            this.EffetBox = new System.Windows.Forms.TextBox();
            this.CompositionBox = new System.Windows.Forms.TextBox();
            this.FamilleBox = new System.Windows.Forms.TextBox();
            this.lblContreIndication = new System.Windows.Forms.Label();
            this.lblEffet = new System.Windows.Forms.Label();
            this.lblComposition = new System.Windows.Forms.Label();
            this.lblFamille = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Size = new System.Drawing.Size(800, 64);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Médicament recherché";
            // 
            // ListeMedicamentBox
            // 
            this.ListeMedicamentBox.FormattingEnabled = true;
            this.ListeMedicamentBox.Location = new System.Drawing.Point(147, 11);
            this.ListeMedicamentBox.Name = "ListeMedicamentBox";
            this.ListeMedicamentBox.Size = new System.Drawing.Size(121, 21);
            this.ListeMedicamentBox.TabIndex = 15;
            this.ListeMedicamentBox.SelectedIndexChanged += new System.EventHandler(this.ListeMedicamentBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ListeMedicamentBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 40);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ContreIndicationBox);
            this.panel3.Controls.Add(this.EffetBox);
            this.panel3.Controls.Add(this.CompositionBox);
            this.panel3.Controls.Add(this.FamilleBox);
            this.panel3.Controls.Add(this.lblContreIndication);
            this.panel3.Controls.Add(this.lblEffet);
            this.panel3.Controls.Add(this.lblComposition);
            this.panel3.Controls.Add(this.lblFamille);
            this.panel3.Location = new System.Drawing.Point(0, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 276);
            this.panel3.TabIndex = 17;
            // 
            // ContreIndicationBox
            // 
            this.ContreIndicationBox.Location = new System.Drawing.Point(15, 210);
            this.ContreIndicationBox.Multiline = true;
            this.ContreIndicationBox.Name = "ContreIndicationBox";
            this.ContreIndicationBox.Size = new System.Drawing.Size(702, 52);
            this.ContreIndicationBox.TabIndex = 7;
            // 
            // EffetBox
            // 
            this.EffetBox.Location = new System.Drawing.Point(15, 133);
            this.EffetBox.Multiline = true;
            this.EffetBox.Name = "EffetBox";
            this.EffetBox.Size = new System.Drawing.Size(702, 58);
            this.EffetBox.TabIndex = 6;
            // 
            // CompositionBox
            // 
            this.CompositionBox.Location = new System.Drawing.Point(15, 68);
            this.CompositionBox.Multiline = true;
            this.CompositionBox.Name = "CompositionBox";
            this.CompositionBox.Size = new System.Drawing.Size(702, 46);
            this.CompositionBox.TabIndex = 5;
            // 
            // FamilleBox
            // 
            this.FamilleBox.Location = new System.Drawing.Point(15, 30);
            this.FamilleBox.Name = "FamilleBox";
            this.FamilleBox.Size = new System.Drawing.Size(306, 20);
            this.FamilleBox.TabIndex = 4;
            // 
            // lblContreIndication
            // 
            this.lblContreIndication.AutoSize = true;
            this.lblContreIndication.Location = new System.Drawing.Point(12, 194);
            this.lblContreIndication.Name = "lblContreIndication";
            this.lblContreIndication.Size = new System.Drawing.Size(87, 13);
            this.lblContreIndication.TabIndex = 3;
            this.lblContreIndication.Text = "Contre Indication";
            // 
            // lblEffet
            // 
            this.lblEffet.AutoSize = true;
            this.lblEffet.Location = new System.Drawing.Point(12, 117);
            this.lblEffet.Name = "lblEffet";
            this.lblEffet.Size = new System.Drawing.Size(29, 13);
            this.lblEffet.TabIndex = 2;
            this.lblEffet.Text = "Effet";
            // 
            // lblComposition
            // 
            this.lblComposition.AutoSize = true;
            this.lblComposition.Location = new System.Drawing.Point(12, 52);
            this.lblComposition.Name = "lblComposition";
            this.lblComposition.Size = new System.Drawing.Size(64, 13);
            this.lblComposition.TabIndex = 1;
            this.lblComposition.Text = "Composition";
            // 
            // lblFamille
            // 
            this.lblFamille.AutoSize = true;
            this.lblFamille.Location = new System.Drawing.Point(12, 14);
            this.lblFamille.Name = "lblFamille";
            this.lblFamille.Size = new System.Drawing.Size(39, 13);
            this.lblFamille.TabIndex = 0;
            this.lblFamille.Text = "Famille";
            // 
            // FrmFicheMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FrmFicheMedicament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFicheMedicament";
            this.Load += new System.EventHandler(this.FrmFicheMedicament_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ListeMedicamentBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblContreIndication;
        private System.Windows.Forms.Label lblEffet;
        private System.Windows.Forms.Label lblComposition;
        private System.Windows.Forms.Label lblFamille;
        private System.Windows.Forms.TextBox FamilleBox;
        private System.Windows.Forms.TextBox CompositionBox;
        private System.Windows.Forms.TextBox ContreIndicationBox;
        private System.Windows.Forms.TextBox EffetBox;
    }
}