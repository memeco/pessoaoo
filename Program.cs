using pessoaoo.Pessoas;

namespace pessoaoo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usando o construtor com parâmetros
            Pessoa pessoa2 = new Pessoa("Lucas", 30, "Torres");
            pessoa2.ImprimirInfo();
     
            // Alterando propriedades diretamente
            pessoa2.Nome = "Emerson";
            pessoa2.ImprimirInfo();
        }

    }
}
