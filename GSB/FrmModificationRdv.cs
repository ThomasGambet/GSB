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
    public partial class FrmModificationRdv : FrmBase {
        public FrmModificationRdv() {
            InitializeComponent();
        }

        private void FrmModificationRdv_Load(object sender, EventArgs e) {
            lblTitre.Text = "Modification de la planification d'un rendez-vous"; 
        }
    }
}
