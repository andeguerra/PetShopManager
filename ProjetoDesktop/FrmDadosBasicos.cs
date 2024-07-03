using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDesktop
{
    public partial class FrmDadosBasicos : Form
    {
        private FrmCadClient parentForm;

        public string Pessoa { get; private set; }
        public string Situação { get; private set; }
        public string ICMS { get; private set; }
        public DateTime Data { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public string ObsDadosBasicos { get; private set; }


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

        public bool ValidarDados()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtCPF.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return false;
            }

            Pessoa = cbPessoa.Text;
            Situação = cbPessoa.Text;
            ICMS = cbICMS.Text;
            Data = dtpData.Value;
            Nome = txtNome.Text;
            CPF = txtCPF.Text;
            RG = txtRG.Text;
            ObsDadosBasicos = txtObs.Text;
            return true;
        }
    }
}
