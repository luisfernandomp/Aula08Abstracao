namespace abstracionProject
{
    public class Cartao : Pagamento
    {
        protected string token = "JSASJDLKN1023PSDK00239102LLMASDNCOAK";
        public string titular { get; set; }
        public int numero { get; set; }
        public string cvv { get; set; }
        public string bandeira { get; set; }

        public bool validarToken(){
            if(token != null){
                return true;
            }else
            {
                
                return false;
            }
        }
        
    }
}