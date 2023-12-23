using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Globais
    {
        public static string caminhoRaiz = Environment.CurrentDirectory;
        public static string caminhoBanco = $@"{caminhoRaiz}\banco\dados.db";
        public static Thread thread;

        // Relacionado ao Usuário (Login)
        public static int Id { get; set; }
        public static string Nome { get; set; }
        public static string Senha { get; set; }
        public static string Nome_Completo { get; set; }
        public static string Email { get; set; }
        public static bool Logado { get; set; } = false;
    }
}
