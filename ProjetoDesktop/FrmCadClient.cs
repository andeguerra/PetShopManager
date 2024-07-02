using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoDesktop
{
    public partial class FrmCadClient : Form
    {
        private Button btnAtual;
        private Form formAtual;
        private Dictionary<string, Form> formCache = new Dictionary<string, Form>();

        public FrmCadClient()
        {
            InitializeComponent();
        }

        private void AtivarBtn(object btnSender)
        {
            if (btnSender != null)
            {
                Button novoBtn = (Button)btnSender;

                // Restaura o tamanho do botão anterior, se houver um botão atual diferente do novo botão clicado
                if (btnAtual != null && btnAtual != novoBtn)
                {
                    btnAtual.Size = new System.Drawing.Size(149, 41);
                }

                // Ativa o novo botão
                btnAtual = novoBtn;
                btnAtual.Size = new System.Drawing.Size(149, 35); // Define o novo tamanho desejado
                pnSelecionado.Location = new Point(btnAtual.Location.X, 54);
            }
        }

        private void DesativarBtn()
        {
            foreach (Control btnAnt in pnCadClient.Controls)
            {
                if (btnAnt.GetType() == typeof(Button))
                {
                    btnAnt.Size = new System.Drawing.Size(149, 41);
                    btnAtual = null;
                }
            }
        }

        private void AbrirForm(Form formsel, object btnSender)
        {
            formAtual?.Hide();

            AtivarBtn(btnSender);

            string formKey = formsel.GetType().Name;

            if (!formCache.ContainsKey(formKey))
            {
                formsel.TopLevel = false;
                formsel.FormBorderStyle = FormBorderStyle.None;
                formsel.Dock = DockStyle.Fill;
                this.pnCadClient.Controls.Add(formsel);
                this.pnCadClient.Tag = formsel;
                formCache[formKey] = formsel;
            }

            formAtual = formCache[formKey];
            formAtual.BringToFront();
            formAtual.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            DesativarBtn(); // Restaura o tamanho do botão anterior
            AtivarBtn(sender);
            AbrirForm(new FrmDadosBasicos(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DesativarBtn(); // Restaura o tamanho do botão anterior
            AtivarBtn(sender);
            AbrirForm(new FrmContatos(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DesativarBtn(); // Restaura o tamanho do botão anterior
            AtivarBtn(sender);
            AbrirForm(new FrmEndereco(), sender);
        }

        private void FrmCadClient_Load(object sender, EventArgs e)
        {
            btnAtual = btnCadastro;
            btnAtual.Size = new Size(149, 35); // Define o tamanho desejado para o botão atual
            pnSelecionado.Location = new Point(btnAtual.Location.X, 54);
            AbrirForm(new FrmDadosBasicos(), btnCadastro);
        }
    }
}
