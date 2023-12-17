using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class GerenciadorDados
    {
        // Cria e retorna a conexão com o banco de dados especificado em DadosGlobais.cs
        public static SQLiteConnection ConectarBanco()
        {
            SQLiteConnection conexao = new SQLiteConnection($"Data Source = {Globais.caminhoBanco}");
            conexao.Open();
            return conexao;
        }

        // Cria e retorna um SQLiteCommand
        public static SQLiteCommand CriarComando(string comandoTexto, SQLiteParameter[] parametros)
        {
            SQLiteCommand comando = new SQLiteCommand(comandoTexto);
            foreach (SQLiteParameter parametro in parametros)
            {
                comando.Parameters.Add(parametro);
            }
            return comando;
        }

        public static SQLiteCommand CriarComando(string comandoTexto, SQLiteParameter parametro)
        {
            SQLiteCommand comando = new SQLiteCommand(comandoTexto);
            comando.Parameters.Add(parametro);
            return comando;
        }

        // Operações de Leitura (DQL) e Escrita (DML) no banco de dados
        public static DataTable DQL(SQLiteCommand consulta)
        {
            using (SQLiteConnection conexao = ConectarBanco())
            {
                consulta.Connection = conexao;
                DataTable retorno = new DataTable();
                SQLiteDataAdapter leitor = new SQLiteDataAdapter(consulta);
                leitor.Fill(retorno);
                return retorno;
            }
        }

        public static void DML(SQLiteCommand escrita)
        {
            using (SQLiteConnection conexao = ConectarBanco())
            {
                escrita.ExecuteNonQuery();
            }
        }
    }
}
