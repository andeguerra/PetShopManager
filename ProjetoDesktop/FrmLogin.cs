using MySql.Data.MySqlClient;
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

namespace ProjetoDesktop
{
    public partial class FrmLogin : Form
    {
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

        private bool mouseDown;
        private Point lastLocation;
        public FrmLogin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            this.MouseDown += FrmLogin_MouseDown;
            this.MouseMove += FrmLogin_MouseMove;
            this.MouseUp += FrmLogin_MouseUp;
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        // Evento MouseMove: Move o formulário enquanto o mouse está pressionado
        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Calcular nova posição do formulário com base no movimento do mouse
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                // Atualizar a exibição para um arrastar mais suave (opcional)
                this.Update();
            }
        }

        // Evento MouseUp: Finaliza o movimento do formulário
        private void FrmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            string sql = $"SELECT * FROM usuarios " +
                $"WHERE nome=@usuario AND senha=@senha";
            Conexao.Conectar();
            MySqlCommand cmd = new MySqlCommand(sql, Conexao.conn);
            DataTable dt = new DataTable();
            cmd.Parameters.AddWithValue("usuario", usuario);
            cmd.Parameters.AddWithValue("senha", senha);
            dt.Load(cmd.ExecuteReader());
            if (dt.Rows.Count == 1)
            {
                Geral.id_usuario = int.Parse(dt.Rows[0]["usuario_id"].ToString());
                Geral.nivel_usuario = int.Parse(dt.Rows[0]["nivel_id"].ToString());
                FrmMenu tela = new FrmMenu();
                this.Hide();
                tela.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha invalido");
            }
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = chbSenha.Checked ? '\0' : '•';
        }
    }
}
