using lesClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GSB {
    public partial class FrmFicheMedicament : FrmBase{
        private Medicament medicament1;
        public FrmFicheMedicament() {
            InitializeComponent();
        }

        private void FrmFicheMedicament_Load(object sender, EventArgs e) {
            lblTitre.Text = "Fiche Médicament";

            foreach (Medicament medicament in Globale.lesMedicaments) {
                ListeMedicamentBox.Items.Add(medicament);
                ListeMedicamentBox.SelectedIndex = 0;
            }
        }
        private void ListeMedicamentBox_SelectedIndexChanged(object sender, EventArgs e) {
            medicament1 = (Medicament)ListeMedicamentBox.SelectedItem;

            FamilleBox.Text = medicament1.LaFamille.Libelle;
            CompositionBox.Text = medicament1.Composition;
            EffetBox.Text = medicament1.Effets;
            ContreIndicationBox.Text = medicament1.ContreIndication;
        }
    }
}
