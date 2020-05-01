using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFinanceiro {
    public partial class Principal : Form {
        public Principal() {
            InitializeComponent();
        }

        private void tsmCadContas_Click(object sender, EventArgs e) {
            Form c = new Contas();
            c.Show();


        }

        private void tsmCadLancamentos_Click(object sender, EventArgs e) {
            Form l = new Lancamentos();
            l.Show();
        }
    }
}
