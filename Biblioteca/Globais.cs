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
        public static int Id { get; set; } = 1;
        public static string Nome { get; set; } = "Filipe";
        public static string Senha { get; set; } = "1234";
        public static string Nome_Completo { get; set; } = "Filipe Emanuel Macarini Roco";
        public static string Email { get; set; } = "filipe.roco@yahoo.com";
        public static bool Logado { get; set; } = false; 
    }
}
