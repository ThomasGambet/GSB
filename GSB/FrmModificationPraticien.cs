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
    public partial class FrmModificationPraticien : FrmBase {
        public FrmModificationPraticien() {
            InitializeComponent();
        }

        private void FrmModificationPraticien_Load(object sender, EventArgs e) { 
            lblTitre.Text = "Modification des praticiens"; 
        }
    }
}
