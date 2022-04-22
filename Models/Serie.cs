using Cadastro_de_séries;

namespace Cadastro_de_séries.Models
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string sobre = "";
            sobre += "Género: " + this.Genero + Environment.NewLine;
            sobre += "Título: " + this.Titulo + Environment.NewLine;
            sobre += "Descrição: " + this.Descricao + Environment.NewLine;
            sobre += "Ano de Lançamento: " + this.Ano + Environment.NewLine;
            sobre += "Excluido: " + this.Excluido;

            return sobre;
        }

        public string getTitulo()
        {
            return this.Titulo;
        }

        public int getId()
        {
            return this.Id;
        }

        public bool Existe()
        {
            return !this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}