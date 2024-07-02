using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProjetoDesktop
{
    public partial class FrmContatos : Form
    {
        private FrmCadClient parentForm;

        public string Celular1 { get; private set; }
        public string Celular2 { get; private set; }
        public string Email { get; private set; }
        public string TelefoneRes { get; private set; }
        public string TelefoneCom { get; private set; }
        public string SiteUrl { get; private set; }
        public string ObsContato { get; private set; }

        public FrmContatos(FrmCadClient parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        public bool ValidarDados()
        {
            if (string.IsNullOrWhiteSpace(mskCel1.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return false;
            }

            Celular1 = mskCel1.Text;
            Celular2 = mskCel2.Text;
            Email = txtEmail.Text;
            TelefoneRes = mskTelRes.Text;
            TelefoneCom = mskTelCom.Text;
            SiteUrl = txtSite.Text;
            ObsContato = txtObs.Text;
            return true;
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
