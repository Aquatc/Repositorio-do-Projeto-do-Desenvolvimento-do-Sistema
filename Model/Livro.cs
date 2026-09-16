namespace Biblioteca.Model
{
    public class Livro
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string Autor { get; set; } = string.Empty;

        public DateTime? DataPublicacao { get; set; }

        public string Genero { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;

        public bool Disponivel { get; set; }
    }
}