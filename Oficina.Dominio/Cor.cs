namespace Oficina.Dominio
{
    // Internal: Acessivel apenas dentro do Assembly.
    public class Cor
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public Cor()
        {
        }

        public Cor(int id,string descricao)
        {
            this.Id = id;
            this.Descricao = descricao;
        }

    }
}