﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFinanceiro {
    public partial class Contas : Form {
        public Contas() {
            InitializeComponent();
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void Contas_Load(object sender, EventArgs e) {
            cboConGrupo.DataSource = Enum.GetNames(typeof(FormContas.Grupos));
        }
    }
}
