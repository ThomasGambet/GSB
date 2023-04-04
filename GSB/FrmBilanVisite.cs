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
    public partial class FrmBilanVisite : FrmBase {
        public FrmBilanVisite() {
            InitializeComponent();
        }

        private void FrmBilanVisite_Load(object sender, EventArgs e) {
            lblTitre.Text = "Enregistrement du bilan d'une visite"; 

        }
    }
}
