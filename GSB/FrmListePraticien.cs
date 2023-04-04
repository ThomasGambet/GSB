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
    public partial class FrmListePraticien : FrmBase {
        public FrmListePraticien() {
            InitializeComponent();
        }

        private void FrmListePraticien_Load(object sender, EventArgs e) { 
            lblTitre.Text = "Liste des praticiens";

            // Affichage des praticiens dans le datagridview
            dgvPraticiens.RowHeadersVisible = false;
            dgvPraticiens.ColumnCount = 5;

            dgvPraticiens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvPraticiens.Columns[0].Name = "Nom et prénom";
            dgvPraticiens.Columns[0].Width = 50;
            dgvPraticiens.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPraticiens.Columns[1].Name = "Téléphone";
            dgvPraticiens.Columns[1].Width = 50;
            dgvPraticiens.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPraticiens.Columns[2].Name = "Email";
            dgvPraticiens.Columns[2].Width = 100;
            dgvPraticiens.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPraticiens.Columns[3].Name = "Adresse";
            dgvPraticiens.Columns[3].Width = 300;
            dgvPraticiens.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPraticiens.Columns[4].Name = "Date dernière visite";
            dgvPraticiens.Columns[4].Width = 200;
            dgvPraticiens.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // On alimente le data grid view avec les praticiens
            Globale.mesPraticiens.ForEach(praticien =>
            {
                // On récupère les visites du praticien et on les trie dans l'ordre du plus grand au plus petit
                // C'est à dire de la plus récente à la moins récente
                List<DateTime> orderedVisites = Globale.mesVisites
                    .Where(visite => visite.LePraticien.Id.Equals(praticien.Id))
                    .Select(visite => visite.DateEtHeure)
                    .OrderByDescending(time => time.Date)
                    .ToList();

                // Par défaut le praticien n'a pas de visite
                // todo Afficher "Aucune visite" en rouge
                string dateDerniereVisite = "Aucune visite";

                // Le praticien a au moins 1 visite
                if (orderedVisites.Count > 0)
                {
                    // On prend la première car c'est la plus récente
                    dateDerniereVisite = orderedVisites[0].ToString("dddd d MMMM yyyy");
                }

                // Ordre d'affichage
                // NomPrenom - Telephone - Email - Rue + CodePostal + Ville - Date dernière visite

                dgvPraticiens.Rows.Add(praticien.NomPrenom, praticien.Telephone, praticien.Email,
                    praticien.Rue + " \n" + praticien.CodePostal + " " + praticien.Ville, dateDerniereVisite);
            });
        }
    }
}
