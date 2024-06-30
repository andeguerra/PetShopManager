using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.IO;


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
        public FrmMenu()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void AbrirForm(Form formsel, object btnSender)
        {
            formAtual?.Close();
            AtivarBtn(btnSender);
            formAtual = formsel;
            formsel.TopLevel = false;
            formsel.FormBorderStyle = FormBorderStyle.None;
            formsel.Dock = DockStyle.Fill;
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
            // Fecha 
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
            AtivarBtn(sender);
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
                //Geral.Sair();
                //FrmLogin tela = new FrmLogin();
                this.Close();
                //tela.Show();
            }
        }

        
    }
}
