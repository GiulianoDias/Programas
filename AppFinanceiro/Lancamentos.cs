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
    public partial class Lancamentos : Form {
        public Lancamentos() {
            InitializeComponent();
        }

        private void Lancamentos_Load(object sender, EventArgs e) {
            lbxLanGrupo.DataSource = Enum.GetNames(typeof(FormContas.Grupos));

            dgvLanResumo.DataSource = FormLancamentos.Consultar();


        }
    }
}
