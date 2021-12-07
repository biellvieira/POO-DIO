namespace ExemploPOO.Models
{
    public abstract class Conta //classe abstract serve apenas de modelo

    {
        protected double saldo; //protected só pode ser alterada com por classes herdeiras

        public abstract void Creditar(double valor); //metodo abstract não possui implementação

        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu saldo é: "+ saldo);
        }
          
    }
}