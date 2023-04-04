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
    public partial class FrmAjoutPraticien : FrmBase {
        public FrmAjoutPraticien() {
            InitializeComponent();
        }

        private void FrmAjoutPraticien_Load(object sender, EventArgs e) {
            lblTitre.Text = "Ajout d'un praticien";

            // On réinitialise les données
            nomBox.Text = "";
            prenomBox.Text = "";
            rueBox.Text = "";
            villeBox.Text = "";
            telBox.Text = "";
            mailBox.Text = "";
            typeBox.Items.Clear();
            speBox.Items.Clear();

            // Auto completion pour les villes
            AutoCompleteStringCollection villeAutoComplete = new AutoCompleteStringCollection();
            villeAutoComplete.AddRange(Globale.mesVilles.Select(ville => ville.Nom).ToArray());
            villeBox.AutoCompleteCustomSource = villeAutoComplete;
            villeBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            villeBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            villeBox.Visible = true;

            // On ajoute les données à partir de la classe Globale
            Globale.lesTypes.ForEach(praticien => typeBox.Items.Add(praticien));
            Globale.lesSpecialites.ForEach(specialite => speBox.Items.Add(specialite));
        }

        private void AjoutBtn_Click(object sender, EventArgs e) {
            // On contrôle la sélection

            if (!Globale.mesVilles.Any(x => x.Nom.Equals(villeBox.Text, StringComparison.InvariantCultureIgnoreCase))) {
                MessageBox.Show(this, "Cette ville n'est pas valide !");
                return;
            }

            // L'utilisateur n'a pas sélectionné de type praticien
            if (typeBox.SelectedItem == null) {
                MessageBox.Show(this, "Vous devez sélectionner un type de praticien !");
                return;
            }

            // L'utilisateur n'a pas sélectionén de spécialité
            if (speBox.SelectedItem == null) {
                MessageBox.Show(this, "Vous devez sélectionner une spécialité !");
                return;
            }

            string nom = nomBox.Text;
            string prenom = prenomBox.Text;
            string rue = rueBox.Text;
            string tel = telBox.Text;
            string email = mailBox.Text;
            Ville ville = Globale.mesVilles.First(x => x.Nom.Equals(villeBox.Text, StringComparison.InvariantCultureIgnoreCase));
            TypePraticien type = (TypePraticien)typeBox.SelectedItem;
            Specialite specialite = (Specialite)speBox.SelectedItem;

            int idPraticien = Passerelle.ajouterPraticien(nom, prenom, rue, ville.Code, ville.Nom, tel, email, type.Id,
                specialite.Id, out string message);

            // Le message est vide il n'y a donc pas eu d'erreur lors de l'ajout du praticien
            if (message.Length == 0) {
                // On crée un objet Praticien à partir de l'id renvoyé par la procédure
                Praticien praticien = new Praticien(idPraticien, nom, prenom, rue, ville.Code, ville.Nom, tel, email,
                    type, specialite);

                // On ajoute l'objet à la liste globale
                Globale.mesPraticiens.Add(praticien);

                FrmAjoutPraticien_Load(sender, e);

                MessageBox.Show("Praticien ajouté !");
                return;
            }

            MessageBox.Show("Une erreur est survenue lors de l'ajout du praticien ! " + message);
        }
    }
}
