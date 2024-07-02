using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProjetoDesktop
{
    public partial class FrmHomeClient : Form
    {
        public FrmHomeClient()
        {
            InitializeComponent();
        }

        private void FrmHomeClient_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn buttonColumn = minhaDataGridView.Columns["botao_consulta"] as DataGridViewButtonColumn;

            buttonColumn.HeaderText = "Ações";
            buttonColumn.Text = "Botão";
            buttonColumn.FlatStyle = FlatStyle.Flat;
            buttonColumn.DefaultCellStyle.Padding = new Padding(10, 3, 10, 3); 
            buttonColumn.UseColumnTextForButtonValue = true;
        }

        private void FrmHomeClient_Shown(object sender, EventArgs e)
        {
            minhaDataGridView.ClearSelection();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmCadClient(), sender);
        }

        private Form formAtual;
        private void AbrirForm(Form formsel, object btnSender)
        {
            formAtual?.Hide();
            formAtual = formsel;
            formsel.TopLevel = false;
            formsel.FormBorderStyle = FormBorderStyle.None;
            formsel.Dock = DockStyle.Fill;
            Geral.PanelCentral.Controls.Add(formsel);
            Geral.PanelCentral.Tag = formsel;
            formsel.BringToFront();
            formsel.Show();
        }
    }
}
