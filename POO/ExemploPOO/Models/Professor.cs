namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar() // override sobrescreve metodo
        {
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade}. Ganho {Salario}");
        }
    }
}