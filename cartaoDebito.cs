namespace abstracionProject
{
    public class cartaoDebito : Cartao
    {
        public float saldo { get; set; }
        
        
        public string Transferir(){
            return "Transferência efetuada!";
        }

        public string pagarTitulo(){
            return "Título pago!";
        }
    }
}