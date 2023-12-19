using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Globais
    {
        public static string caminhoRaiz = Environment.CurrentDirectory;
        public static string caminhoBanco = $@"{caminhoRaiz}\banco\dados.db";
        public static Thread thread;
    }
}
