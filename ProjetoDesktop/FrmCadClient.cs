using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            // Recebendo confirmação de validade das funções nos formulários de cadastro
            bool dadosBasicosValidos = ((FrmDadosBasicos)formsCache["FrmDadosBasicos"]).ValidarDados();
            bool enderecoValido = ((FrmEndereco)formsCache["FrmEndereco"]).ValidarDados();
            bool contatosValidos = ((FrmContatos)formsCache["FrmContatos"]).ValidarDados();

            if (dadosBasicosValidos && enderecoValido && contatosValidos)
            {
                // Executando código para receber as informações dos formulários
                // Dados básicos
                string pessoa = ((FrmDadosBasicos)formsCache["FrmDadosBasicos"]).Pessoa;
                string situacao = ((FrmDadosBasicos)formsCache["FrmDadosBasicos"]).Situação;
                string icms = ((FrmDadosBasicos)formsCache["FrmDadosBasicos"]).ICMS;
                DateTime data = ((FrmDadosBasicos)formsCache["FrmDadosBasicos"]).Data;
                string nome = ((FrmDadosBasicos)formsCache["FrmDadosBasicos"]).Nome;
                string cpf = ((FrmDadosBasicos)formsCache["FrmDadosBasicos"]).CPF;
                string rg = ((FrmDadosBasicos)formsCache["FrmDadosBasicos"]).RG;
                string obsDados = ((FrmDadosBasicos)formsCache["FrmDadosBasicos"]).ObsDadosBasicos;

                // Dados de endereço
                string cep = ((FrmEndereco)formsCache["FrmEndereco"]).Cep;
                string uf = ((FrmEndereco)formsCache["FrmEndereco"]).UF;
                string cidade = ((FrmEndereco)formsCache["FrmEndereco"]).Cidade;
                string bairro = ((FrmEndereco)formsCache["FrmEndereco"]).Bairro;
                string logradouro = ((FrmEndereco)formsCache["FrmEndereco"]).Logradouro;
                string numero = ((FrmEndereco)formsCache["FrmEndereco"]).Numero;
                string complemento = ((FrmEndereco)formsCache["FrmEndereco"]).Complemento;
                string obsEndereco = ((FrmEndereco)formsCache["FrmEndereco"]).ObsEndereco;

                // Dados de contato
                string celular1 = ((FrmContatos)formsCache["FrmContatos"]).Celular1;
                string celular2 = ((FrmContatos)formsCache["FrmContatos"]).Celular2;
                string email = ((FrmContatos)formsCache["FrmContatos"]).Email;
                string telRes = ((FrmContatos)formsCache["FrmContatos"]).TelefoneRes;
                string telCom = ((FrmContatos)formsCache["FrmContatos"]).TelefoneCom;
                string site = ((FrmContatos)formsCache["FrmContatos"]).SiteUrl;
                string obsContato = ((FrmContatos)formsCache["FrmContatos"]).ObsContato;

                // Iniciando a conexão e abrindo transação com banco de dados
                try
                {
                    Conexao.Conectar();

                    using (MySqlTransaction transaction = Conexao.conn.BeginTransaction())
                    {
                        try
                        {
                            // Inserindo dados na tabela de Endereços
                            string sql1 = "INSERT INTO endereco(cep, uf, cidade, bairro, logradouro, num, compl1, obs) " +
                                "VALUES(@cep, @uf, @cidade, @bairro, @logradouro, @num, @compl1, @obs);";
                            MySqlCommand cmdEndereco = new MySqlCommand(sql1, Conexao.conn, transaction);

                            cmdEndereco.Parameters.AddWithValue("@cep", cep);
                            cmdEndereco.Parameters.AddWithValue("@uf", uf);
                            cmdEndereco.Parameters.AddWithValue("@cidade", cidade);
                            cmdEndereco.Parameters.AddWithValue("@bairro", bairro);
                            cmdEndereco.Parameters.AddWithValue("@logradouro", logradouro);
                            cmdEndereco.Parameters.AddWithValue("@num", numero);
                            cmdEndereco.Parameters.AddWithValue("@compl1", complemento);
                            cmdEndereco.Parameters.AddWithValue("@obs", obsEndereco);

                            cmdEndereco.ExecuteNonQuery();
                            int enderecoId = (int)cmdEndereco.LastInsertedId; // Corrigido para pegar o último ID inserido

                            // Inserindo dados na tabela de Clientes
                            string sql2 = "INSERT INTO clientes(pessoa, nome, cpf, rg, celular1, celular2, telefoneres, telefonecom, email, site, obsdados, obscontato, fidelidade_pontos, endereco_id) " +
                                "VALUES(@pessoa, @nome, @cpf, @rg, @celular1, @celular2, @telefoneres, @telefonecom, @email, @site, @obsdados, @obscontato, @fidelidade_pontos, @endereco_id);";

                            MySqlCommand cmdClientes = new MySqlCommand(sql2, Conexao.conn, transaction);

                            cmdClientes.Parameters.AddWithValue("@pessoa", pessoa);
                            cmdClientes.Parameters.AddWithValue("@nome", nome);
                            cmdClientes.Parameters.AddWithValue("@cpf", cpf);
                            cmdClientes.Parameters.AddWithValue("@rg", rg);
                            cmdClientes.Parameters.AddWithValue("@celular1", celular1);
                            cmdClientes.Parameters.AddWithValue("@celular2", celular2);
                            cmdClientes.Parameters.AddWithValue("@telefoneres", telRes);
                            cmdClientes.Parameters.AddWithValue("@telefonecom", telCom);
                            cmdClientes.Parameters.AddWithValue("@email", email);
                            cmdClientes.Parameters.AddWithValue("@site", site);
                            cmdClientes.Parameters.AddWithValue("@obsdados", obsDados);
                            cmdClientes.Parameters.AddWithValue("@obscontato", obsContato);
                            cmdClientes.Parameters.AddWithValue("@fidelidade_pontos", 0);
                            cmdClientes.Parameters.AddWithValue("@endereco_id", enderecoId); // Adicionando o ID do endereço

                            cmdClientes.ExecuteNonQuery();

                            transaction.Commit();

                            MessageBox.Show("Dados salvos com sucesso.");
                        }
                        catch (Exception ex)
                        {
                            // Em caso de erro, desfaz a transação
                            try
                            {
                                transaction.Rollback();
                            }
                            catch (Exception rollbackEx)
                            {
                                MessageBox.Show("Erro ao tentar reverter a transação: " + rollbackEx.Message);
                            }
                            MessageBox.Show("Erro ao inserir dados: " + ex.Message);
                        }
                    }
                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show("Erro ao tentar salvar os dados: " + sqlEx.Message);
                }
                finally
                {
                    Conexao.Desconectar();
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.");
            }
        }
    }
}
