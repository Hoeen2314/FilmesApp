using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmesApp.Moddels
{
    public class Filme
    {
        private int id;
        private string nome;
        private int anoLancamento;

        public int Id { get =>  id; set => id = value; }
        public string Name { get => nome; set => nome = value; }
        public int AnoLancamento { get => anoLancamento; set => anoLancamento = value;}
        public virtual List<Filme> Filmes { get; set; }

        public Filme()
        {
            nome = "";
            Filmes = new List<Filme>();
        }
        
    }
}
