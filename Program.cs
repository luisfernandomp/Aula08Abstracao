using System;

namespace abstracionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            cartaoCredito visa = new cartaoCredito();
            visa.limite = 3000f;

            System.Console.WriteLine("Informe o valor do acréscimo?");
            float acres = float.Parse(Console.ReadLine());

            visa.aumentarLimite(acres);
            System.Console.WriteLine("Novo limite: R$"+visa.limite);

            System.Console.WriteLine("Digite a data do pagamento: ");
            visa.data = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Data: "+ visa.data);

            cartaoDebito master = new cartaoDebito();
            master.saldo = 900f;
            string msg = master.pagarTitulo();
            System.Console.WriteLine("Saldo do cartão de débito: "+master.saldo);
            System.Console.WriteLine(msg);
        }
    }
}
