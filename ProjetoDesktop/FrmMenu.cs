﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using System.Drawing.Text;


namespace ProjetoDesktop
{
    public partial class FrmMenu : Form
    {
        bool sidebarExpand = true;
        private PrivateFontCollection privateFonts = new PrivateFontCollection();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private Button btnAtual;
        private Form formAtual;
        List<Form> formsParaFechar = new List<Form>();
        private bool mouseDown;
        private Point lastLocation;
        public FrmMenu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            panel2.MouseDown += Panel2_MouseDown;
            panel2.MouseMove += Panel2_MouseMove;
            panel2.MouseUp += Panel2_MouseUp;
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        // Evento MouseMove no panel2: Move o formulário enquanto o mouse está pressionado
        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Calcular nova posição do formulário com base no movimento do mouse relativo ao panel2
                this.Location = new Point(
                    this.Location.X + (e.X - lastLocation.X),
                    this.Location.Y + (e.Y - lastLocation.Y));

                // Atualizar a exibição para um arrastar mais suave (opcional)
                this.Update();
            }
        }

        // Evento MouseUp no panel2: Finaliza o movimento do formulário
        private void Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void AbrirForm(Form formsel, object btnSender)
        {
            formAtual?.Close();
            AtivarBtn(btnSender);
            formAtual = formsel;
            formsel.TopLevel = false;
            formsel.FormBorderStyle = FormBorderStyle.None;
            formsel.Dock = DockStyle.None;
            formsel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            formsel.Location = new Point(0, 0);
            formsel.Size = pnCentral.Size;
            this.pnCentral.Controls.Add(formsel);
            this.pnCentral.Tag = formsel;
            formsel.BringToFront();
            formsel.Show();
        }

        private void AtivarBtn(object btnSender)
        {
            if (btnSender != null)
            {
                if (btnAtual != (Button)btnSender)
                {
                    DesativarBtn();
                    btnAtual = (Button)btnSender;
                    btnAtual.BackColor = Color.FromArgb(51, 51, 51);
                    pnlWhiteForm.Location = new Point(btnAtual.Location.X, btnAtual.Location.Y);
                }
            }
        }

        private void DesativarBtn()
        {
            foreach (Control btnAnt in pnlSidebar.Controls)
            {
                if (btnAnt.GetType() == typeof(Button))
                {
                    btnAnt.BackColor = Color.FromArgb(30, 30, 30);
                    btnAtual = null;
                }
            }
        }

        // Código do timer para expandir a barra lateral
        private void tmrSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pnlSidebar.Width -= 10;
                if(pnlSidebar.Width == pnlSidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    tmrSidebar.Stop();
                }
            }
            else
            {
                pnlSidebar.Width += 10;
                if(pnlSidebar.Width == pnlSidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    tmrSidebar.Stop();
                }
            }
        }

        // Botão para expandir barra lateral
        private void btnMenu_Click(object sender, EventArgs e)
        {
            tmrSidebar.Start();
        }

        // Salva o painel principal na classe
        private void Form1_Load(object sender, EventArgs e)
        {
            Geral.PanelCentral = pnCentral;
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            AtivarBtn(sender);
            // Fecha outras janelas já abertas antes
            foreach (Control item in pnCentral.Controls)
            {
                if (item is Form form)
                {
                    formsParaFechar.Add(form);
                }
            }
            foreach (Form form in formsParaFechar)
            {
                form.Close();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmHomeClient(), sender);
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            AbrirForm(new TelaAnimais1(), sender);
        }

        private void btnAtendimento_Click(object sender, EventArgs e)
        {
            AtivarBtn(sender);
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            AtivarBtn(sender);
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            AtivarBtn(sender);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            AtivarBtn(sender);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var dialogRes = MessageBox.Show("Deseja sair do sistema?",
                "Sair do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogRes == DialogResult.Yes)
            {
                Geral.Sair();
                FrmLogin tela = new FrmLogin();
                this.Hide();
                tela.Show();
            }
        }
    }
}
