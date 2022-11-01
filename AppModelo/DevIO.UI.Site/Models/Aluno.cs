namespace DevIO.UI.Site.Models
{
    public class Aluno
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public Aluno()
        {
            Id = new Guid();
        }
    }
}
