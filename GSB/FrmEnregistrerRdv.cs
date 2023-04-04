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
    public partial class FrmEnregistrerRdv : FrmBase {
        public FrmEnregistrerRdv() {
            InitializeComponent();
        }

        private void FrmEnregistrerRdv_Load(object sender, EventArgs e) {
            parametrerComposant();
        }

        private void parametrerComposant()
        {
            this.lblTitre.Text = "Enregistrer un nouveau rendez-vous";

            // Réinitialiser l'interface du composant
            dgvVisite.ClearSelection();
            dgvVisite.Rows.Clear();
            cbxPraticien.Items.Clear();
            cbxMotif.Items.Clear();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.CustomFormat = "dddd dd MMMM yyyy HH:mm tt";

            // Création des colonnes 
            dgvVisite.RowHeadersVisible = false;
            dgvVisite.ColumnCount = 5;

            dgvVisite.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Cette colonne sert à stocker l'id de l'objet pour le manipuler après
            // Il n'est donc pas utile de l'afficher, on a juste besoin de la donnée
            dgvVisite.Columns[0].Visible = false;
            dgvVisite.Columns[0].Name = "Id";

            dgvVisite.Columns[1].Name = "programmée le";
            dgvVisite.Columns[1].Width = 150;
            dgvVisite.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisite.Columns[2].Name = "à";
            dgvVisite.Columns[2].Width = 25;
            dgvVisite.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisite.Columns[3].Name = "sur";
            dgvVisite.Columns[3].Width = 50;
            dgvVisite.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisite.Columns[4].Name = "chez";
            dgvVisite.Columns[4].Width = 100;
            dgvVisite.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // On remplit les données
            Globale.mesVisites.ForEach(visite => {

                // Ordre d'affichage
                // Id(masqué) -> date -> heure -> ville
                dgvVisite.Rows.Add(visite.Id, visite.DateEtHeure.ToString("dddd d MMMM yyyy"), visite.DateEtHeure.ToString("HH:mm"), visite.LePraticien.Ville, visite.LePraticien.NomPrenom);
            });

            Globale.mesPraticiens.ForEach(praticien => cbxPraticien.Items.Add(praticien));
            Globale.lesMotifs.ForEach(motif => cbxMotif.Items.Add(motif));

        }

        private void ajoutBtn_Click(object sender, EventArgs e) {

            // On vérifie que l'utilisateur a bien sélectionné un praticien
            if (cbxPraticien.SelectedItem == null) {
                MessageBox.Show(this, "Vous devez sélectionner un praticien !");
                return;
            }

            // On vérifie que l'utilisateur a bien sélectionné un motif
            if (cbxMotif.SelectedItem == null) {
                MessageBox.Show(this, "Vous devez sélectionner un motif !");
                return;
            }

            Praticien praticien = (Praticien)cbxPraticien.SelectedItem;
            Motif motif = (Motif)cbxMotif.SelectedItem;
            DateTime date = dateTimePicker1.Value;

            int idVisite = Passerelle.ajouterRendezVous(praticien.Id, motif.Id, date, out var message);

            // Si le message est vide alors il n'y a pas eu d'erreur lors de l'ajout
            if (message.Length == 0) {
                // On crée l'objet Visite et l'ajoute à la liste "mesVisites" de l'utilisateur
                Visite visite = new Visite(idVisite, praticien, motif, date);
                Globale.mesVisites.Add(visite);

                // On recharge les données pour afficher le nouveau rendez-vous ajouté
                FrmEnregistrerRdv_Load(sender, e);

                MessageBox.Show(this, "Visite ajoutée !");
                return;
            }

            // temporaire pour le debug
            Console.WriteLine(message);

            MessageBox.Show(this, "Une erreur est survenue lors de l'ajout d'une visite " + message);
        }
    }
}
