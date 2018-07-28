namespace Oficina.Dominio
{
    public class Marca
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Marca()
        {
        }

        public Marca(int id,string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
    }
}