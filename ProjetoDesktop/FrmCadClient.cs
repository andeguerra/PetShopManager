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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var dialogRes = MessageBox.Show("Deseja cancelar o cadastro?",
                "Cancelar cdastro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogRes == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool dadosBasicosValidos = ((FrmDadosBasicos)formsCache["FrmDadosBasicos"]).ValidarDados();
            bool enderecoValido = ((FrmEndereco)formsCache["FrmEndereco"]).ValidarDados();
            bool contatosValidos = ((FrmContatos)formsCache["FrmContatos"]).ValidarDados();

            if (dadosBasicosValidos && enderecoValido && contatosValidos)
            {
                // Aqui você pode acessar os dados de cada formulário
                string pessoa = ((FrmDadosBasicos)formsCache["FrmDadosBasicos"]).Pessoa;
                string situacao = ((FrmDadosBasicos)formsCache["FrmDadosBasicos"]).Situação;
                string icms = ((FrmDadosBasicos)formsCache["FrmDadosBasicos"]).ICMS;
                DateTime data = ((FrmDadosBasicos)formsCache["FrmDadosBasicos"]).Data;
                string nome = ((FrmDadosBasicos)formsCache["FrmDadosBasicos"]).Nome;
                string cpf = ((FrmDadosBasicos)formsCache["FrmDadosBasicos"]).CPF;
                string rg = ((FrmDadosBasicos)formsCache["FrmDadosBasicos"]).RG;
                string obsDados = ((FrmDadosBasicos)formsCache["FrmDadosBasicos"]).ObsDadosBasicos;

                string cep = ((FrmEndereco)formsCache["FrmEndereco"]).Cep;
                string logradouro = ((FrmEndereco)formsCache["FrmEndereco"]).Logradouro;
                string numero = ((FrmEndereco)formsCache["FrmEndereco"]).Numero;
                string uf = ((FrmEndereco)formsCache["FrmEndereco"]).UF;
                string cidade = ((FrmEndereco)formsCache["FrmEndereco"]).Cidade;
                string bairro = ((FrmEndereco)formsCache["FrmEndereco"]).Bairro;
                string complemento = ((FrmEndereco)formsCache["FrmEndereco"]).Complemento;
                string obsEndereco = ((FrmEndereco)formsCache["FrmEndereco"]).ObsEndereco;

                string celular1 = ((FrmContatos)formsCache["FrmContatos"]).Celular1;
                string celular2 = ((FrmContatos)formsCache["FrmContatos"]).Celular2;
                string email = ((FrmContatos)formsCache["FrmContatos"]).Email;
                string telRes = ((FrmContatos)formsCache["FrmContatos"]).TelefoneRes;
                string telCom = ((FrmContatos)formsCache["FrmContatos"]).TelefoneCom;
                string site = ((FrmContatos)formsCache["FrmContatos"]).SiteUrl;
                string obsContato = ((FrmContatos)formsCache["FrmContatos"]).ObsContato;

                // Aqui você pode executar a instrução SQL de insert com os dados obtidos
                // Exemplo:
                // string query = $"INSERT INTO Tabela (Nome, Idade, Rua, Cidade, Telefone, Email) " +
                //                $"VALUES ('{nomeCliente}', {idadeCliente}, '{rua}', '{cidade}', " +
                //                $"'{telefone}', '{email}')";
                // Execute a query no seu banco de dados

                MessageBox.Show("Dados salvos com sucesso!");
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.");
            }
        }
    }
}
