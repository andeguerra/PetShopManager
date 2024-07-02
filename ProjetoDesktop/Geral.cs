using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDesktop
{
    internal class Geral
    {
        // Elementos visuais
        public static Panel PanelCentral;

        // Identificação de usuário logado
        public static int nivel_usuario = 0;
        public static int id_usuario = 0;

        // Função para sinalizar o logoff de um usuário
        public static void Sair()
        {
            nivel_usuario = 0;
            id_usuario = 0;
        }

        // Função de útil para buscar dados no BD
        public static DataTable Selecionar(string sql)
        {
            Conexao.Conectar();
            MySqlCommand cmd = new MySqlCommand(sql, Conexao.conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Conexao.Desconectar();

            return dt;
        }
    }
}
