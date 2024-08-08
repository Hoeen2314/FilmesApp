using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmesApp.Moddels
{
    public class Ator
    {
        private int id;
        private string nome;
        private int idade;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public virtual List<Ator> Atores { get; set; }

        public Ator()
        {
            nome = "";
            Atores = new List<Ator>();
        }
        
    }
}
