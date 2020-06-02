using System;

namespace abstracionProject
{
    public class Pagamento
    {
        public DateTime data { get; set; }
        public float valor { get; set; }

        public string Pagar(float valor){
            float valorPago = valor;
            return "Valor pago : R$"+valorPago;
        }
        public string Cancelar(){
            return "Pagamento Cancelado!";
        }

    }
}