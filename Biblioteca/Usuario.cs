using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Biblioteca
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Nome_Completo { get; set; }
        public string Email { get; set; }

        public Usuario(int id, string nome, string senha, string nome_completo, string email)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Nome_Completo = nome_completo;
            Email = email;
        }
    }
}
