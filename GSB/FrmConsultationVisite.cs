using lesClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB {
    public partial class FrmConsultationVisite : FrmBase {

        public FrmConsultationVisite() {
            InitializeComponent();
        }

        private void FrmConsultationVisite_Load(object sender, EventArgs e) {
            lblTitre.Text = "Consultation des visites";

            dgvVisite.ClearSelection();
            dgvVisite.Rows.Clear();
            dgvVisite.Columns.Clear();



            dgvVisite.ColumnCount = 4;
            dgvVisite.RowHeadersVisible = false;
            dgvVisite.SelectionMode= DataGridViewSelectionMode.FullRowSelect;

            dgvVisite.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvVisite.Columns[0].Name = "Id";
            dgvVisite.Columns[0].Visible = false;
            dgvVisite.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisite.Columns[1].Name = "Programmé le";
            dgvVisite.Columns[1].Width = 150;
            dgvVisite.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisite.Columns[2].Name = "à";
            dgvVisite.Columns[2].Width = 50;
            dgvVisite.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisite.Columns[3].Name = "sur";
            dgvVisite.Columns[3].Width = 100;
            dgvVisite.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisite.Columns[0].ValueType = typeof(DateTime);
            this.dgvVisite.Sort(this.dgvVisite.Columns[0], ListSortDirection.Ascending);

            // On alimente le data grid view avec les visites
            Globale.mesVisites.ForEach(visite => {

                // Ordre d'affichage
                // Id(masqué) -> date -> heure -> ville
                dgvVisite.Rows.Add(visite.Id,visite.DateEtHeure.ToString("dddd d MMMM yyyy"), visite.DateEtHeure.ToString("HH:mm"), visite.LePraticien.Ville);
            });

            // Par défaut, sélectionner la première visite si elle existe
            if (dgvVisite.RowCount > 0) {
                // On force le clique sur la cellule de la première ligne de première colonne
                dgvVisite_CellContentClick(sender, new DataGridViewCellEventArgs(0, 0));
            }
        }

        private void dgvVisite_CellClick(object sender, DataGridViewCellEventArgs e) {
            /*if (e.ColumnIndex == 5 && e.RowIndex >= 0) {
                Visite v = dgvVisite[0, e.RowIndex].Value as Visite;

                Visite visite = Globale.mesVisites.Find(x => x.Id.Equals(v));

                lePraticien.Text = visite.LePraticien.NomPrenom;
                laRue.Text = visite.LePraticien.Rue;
                leTelephone.Text = visite.LePraticien.Telephone;
                mail.Text = visite.LePraticien.Email;
                leTypePraticien.Text = visite.LePraticien.Type.ToString();
                laSpecialite.Text = visite.LePraticien.Specialite.ToString();

                leMotif.Text = visite.LeMotif.ToString();

                BilanBox.Text = visite.Bilan;
            }*/
        }

        private void dgvVisite_SelectionChanged(object sender, EventArgs e) {

        }

        private void dgvVisite_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            
            DataGridViewRow row = dgvVisite.Rows[e.RowIndex];

            
            DataGridViewCell idCell = row.Cells[0];
            int idVisite = (int)idCell.Value;

            Visite visite = Globale.mesVisites.Find(x => x.Id.Equals(idVisite));

            //alimentation des champs

            lePraticien.Text = visite.LePraticien.NomPrenom;
            laRue.Text = visite.LePraticien.Rue;
            leTelephone.Text = visite.LePraticien.Telephone;
            mail.Text = visite.LePraticien.Email;
            leTypePraticien.Text = visite.LePraticien.Type.ToString();
            laSpecialite.Text = visite.LePraticien.Specialite.ToString();

            leMotif.Text = visite.LeMotif.ToString();

            BilanBox.Text = visite.Bilan;

            
            row.Selected = true;
        }
    }
}
