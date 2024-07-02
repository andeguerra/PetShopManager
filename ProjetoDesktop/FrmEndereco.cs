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
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoDesktop
{
    public partial class FrmEndereco : Form
    {
        private FrmCadClient parentForm;
        public string Cep { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string UF { get; private set; }
        public string Cidade { get; private set; }
        public string Bairro { get; private set; }
        public string Complemento { get; private set; }
        public string ObsEndereco { get; private set; }
        public FrmEndereco(FrmCadClient parent)
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

        public static async Task<Endereco> ObterEnderecoPorCep(string cep)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<Endereco>(json);
                    }
                    else
                    {
                        MessageBox.Show($"Erro na consulta: {response.StatusCode}");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                    return null;
                }
            }
        }

        public class Endereco
        {
            [JsonProperty("cep")]
            public string Cep { get; set; }

            [JsonProperty("logradouro")]
            public string Logradouro { get; set; }

            [JsonProperty("complemento")]
            public string Complemento { get; set; }

            [JsonProperty("bairro")]
            public string Bairro { get; set; }

            [JsonProperty("localidade")]
            public string Localidade { get; set; }

            [JsonProperty("uf")]
            public string Uf { get; set; }

            [JsonProperty("ibge")]
            public string Ibge { get; set; }

            [JsonProperty("gia")]
            public string Gia { get; set; }

            [JsonProperty("ddd")]
            public string Ddd { get; set; }

            [JsonProperty("siafi")]
            public string Siafi { get; set; }
        }

        private async void mskCep_TextChanged(object sender, EventArgs e)
        {
            if (mskCep.Text.Length >= 10)
            {
                string cep = new string(mskCep.Text.Where(char.IsDigit).ToArray());

                if (!string.IsNullOrEmpty(cep))
                {
                    var endereco = await ObterEnderecoPorCep(cep);
                    if (endereco != null)
                    {
                        txtLogradouro.Text = endereco.Logradouro;
                        txtBairro.Text = endereco.Bairro;
                        txtCidade.Text = endereco.Localidade;
                        txtUf.Text = endereco.Uf;
                    }
                    else
                    {
                        MessageBox.Show("CEP não encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um CEP.");
                }
            }
        }

        private void mskCep_Click(object sender, EventArgs e)
        {
            if (mskCep.Text.Where(char.IsDigit).ToArray().Length < 1)
            {
                mskCep.SelectionStart = 0;
            }
        }

        public bool ValidarDados()
        {
            if (string.IsNullOrWhiteSpace(mskCep.Text) || string.IsNullOrWhiteSpace(txtLogradouro.Text) || 
                string.IsNullOrWhiteSpace(txtUf.Text) || string.IsNullOrWhiteSpace(txtCidade.Text) || 
                string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return false;
            }

            Cep = mskCep.Text;
            Logradouro = txtLogradouro.Text;
            Numero = txtNumero.Text;
            UF = txtUf.Text;
            Cidade = txtCidade.Text;
            Bairro = txtBairro.Text;
            Complemento = txtComplemento.Text;
            ObsEndereco = txtObs.Text;
            return true;
        }
    }
}
