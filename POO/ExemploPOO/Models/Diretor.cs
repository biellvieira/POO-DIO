namespace ExemploPOO.Models
{
    public sealed class Diretor : Professor //classe sealed não permite ser herdada
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Diretor");
        }
        
    }
}