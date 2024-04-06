namespace pessoaoo.Pessoas
{
    public class Pessoa
    {
        // Propriedades privadas encapsuladas
        private string nome;
        private int idade;
        private string endereco;


        // Construtor com parâmetros
        public Pessoa(string nome, int idade, string endereco)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
        }
        // Getter e Setter para o nome
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        // Método para imprimir informações da pessoa
        public void ImprimirInfo()
        {
            Console.WriteLine($"Nome: {nome}, Idade: {idade}, Endereço: {endereco}");
        }
    }
}