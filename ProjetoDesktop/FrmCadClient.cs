﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoDesktop
{
    public partial class FrmCadClient : Form
    {
        private Button btnAtual;
        private Form formAtual;
        private Dictionary<string, Form> formsCache;

        public FrmCadClient()
        {
            InitializeComponent();
            formsCache = new Dictionary<string, Form>();
        }

        private void AtivarBtn(object btnSender)
        {
            if (btnSender != null)
            {
                Button novoBtn = (Button)btnSender;

                if (btnAtual != null && btnAtual != novoBtn)
                {
                    btnAtual.Size = new System.Drawing.Size(149, 41);
                }

                btnAtual = novoBtn;
                btnAtual.Size = new System.Drawing.Size(149, 35);
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
            if (formAtual != null)
            {
                formAtual.Hide();
            }

            AtivarBtn(btnSender);

            if (formsel != null)
            {
                formAtual = formsel;
                formsel.TopLevel = false;
                formsel.FormBorderStyle = FormBorderStyle.None;
                formsel.Dock = DockStyle.Fill;
                this.pnCadClient.Controls.Add(formsel);
                this.pnCadClient.Tag = formsel;
                formsel.BringToFront();
                formsel.Show();
            }
        }

        private void AbrirOuCriarForm(string formName, Func<Form> formFactory, object btnSender)
        {
            if (!formsCache.ContainsKey(formName))
            {
                var form = formFactory();
                formsCache[formName] = form;
            }
            AbrirForm(formsCache[formName], btnSender);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            DesativarBtn();
            AtivarBtn(sender);
            AbrirOuCriarForm("FrmDadosBasicos", () => new FrmDadosBasicos(this), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DesativarBtn();
            AtivarBtn(sender);
            AbrirOuCriarForm("FrmContatos", () => new FrmContatos(this), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DesativarBtn();
            AtivarBtn(sender);
            AbrirOuCriarForm("FrmEndereco", () => new FrmEndereco(this), sender);
        }

        private void FrmCadClient_Load(object sender, EventArgs e)
        {
            btnCadastro_Click(btnCadastro, EventArgs.Empty);
            btnAtual = btnCadastro;
            btnAtual.Size = new Size(149, 35);
            pnSelecionado.Location = new Point(btnAtual.Location.X, 54);
        }
    }
}
