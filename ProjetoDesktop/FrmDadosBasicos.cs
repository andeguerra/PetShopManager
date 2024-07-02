﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDesktop
{
    public partial class FrmDadosBasicos : Form
    {
        private FrmCadClient parentForm;

        public FrmDadosBasicos(FrmCadClient parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var dialogRes = MessageBox.Show("Deseja cancelar o cadastro?",
                "Cancelar cdastro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogRes == DialogResult.Yes)
            {
                parentForm.Close();
            }
        }
    }
}
