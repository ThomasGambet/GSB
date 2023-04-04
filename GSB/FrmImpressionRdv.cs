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
    public partial class FrmImpressionRdv : FrmBase {
        public FrmImpressionRdv() {
            InitializeComponent();
        }

        private void FrmImpressionRdv_Load(object sender, EventArgs e) {
            lblTitre.Text = "Impression des rendez-vous sur une période"; 
        }
    }
}
