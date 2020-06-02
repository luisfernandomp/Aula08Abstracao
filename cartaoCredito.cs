namespace abstracionProject
{
    public class cartaoCredito : Cartao
    {
        public float limite { get; set; }
        
        public void aumentarLimite(float acres){
            limite = limite + acres;
        }        
    }
}