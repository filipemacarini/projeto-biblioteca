using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
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
                escrita.Connection = conexao;
                escrita.ExecuteNonQuery();
            }
        }

        // Adiciona um novo usuário / Atualiza um usúario existente

        public static void AdicionarUsuario(string nome, string senha, string nomeCompleto, string email)
        {
            string consulta = $@"insert into Usuarios (Nome, Senha, Nome_Completo, Email) values(@Nome, @Senha, @NomeCompleto, @Email)";
            SQLiteParameter[] parametros = new SQLiteParameter[]
            {
                new SQLiteParameter("@Nome", nome),
                new SQLiteParameter("@Senha", senha),
                new SQLiteParameter("@NomeCompleto", nomeCompleto),
                new SQLiteParameter("@Email", email)
            };
            SQLiteCommand comando = GerenciadorDados.CriarComando(consulta, parametros);
            DML(comando);
        }

        public static void AtualizarUsuario(int id, string nome, string senha, string nomeCompleto, string email)
        {
            using (SQLiteConnection conexao = ConectarBanco())
            {
                string consulta = $@"update Usuarios set Nome = @Nome, Senha = @Senha, Nome_Completo = @NomeCompleto, Email = @Email where ID_Usuario = @ID";
                SQLiteParameter[] parametros = new SQLiteParameter[]
                {
                    new SQLiteParameter("@Nome", nome),
                    new SQLiteParameter("@Senha", senha),
                    new SQLiteParameter("@NomeCompleto", nomeCompleto),
                    new SQLiteParameter("@Email", email),
                    new SQLiteParameter("@ID", id)
                };
                SQLiteCommand comando = GerenciadorDados.CriarComando(consulta, parametros);
                DML(comando);
            }
        }

        // Retorna os dados de um ou mais usuarios

        public static DataTable PegarUsuarios(string coluna, string valor, int id = -1)
        {
            string excecao = id > -1 ? "and ID_Usuario != @Id" : "";
            string consulta = $@"select * from Usuarios where {coluna} = @Valor {excecao}";
            SQLiteCommand comando = GerenciadorDados.CriarComando(consulta, new SQLiteParameter("@Valor", valor));
            if (id > -1) { comando = GerenciadorDados.CriarComando(consulta, new[] { new SQLiteParameter("@Valor", valor), new SQLiteParameter("@Id", id) }); }
            else { comando = GerenciadorDados.CriarComando(consulta, new SQLiteParameter("@Valor", valor)); }
            return GerenciadorDados.DQL(comando);
        }
    }
}
