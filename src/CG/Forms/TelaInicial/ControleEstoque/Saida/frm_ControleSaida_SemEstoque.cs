﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG.TelaInicial.ControleEstoque.Saida
{
    public partial class frm_ControleSaida_SemEstoque : Form
    {
        public frm_ControleSaida_SemEstoque()
        {
            InitializeComponent();
        }

        public frm_ControleSaida_SemEstoque(DataTable resultado)
        {
            InitializeComponent();
            dgv_ControleSaidaSemEstoque.DataSource = resultado;

        }
        private void frm_ControleSaida_SemEstoque_Load(object sender, EventArgs e)
        {

        }
    }
}
