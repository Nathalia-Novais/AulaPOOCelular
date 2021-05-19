namespace celular_
{
    public class celular1
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado = false;

        public bool Ligar(){
            ligado = true;
            return ligado;
        }
        
         public bool desligar(){
            ligado = false;
            return ligado;
        }

        public string Ligacao(){
            return "Chamando....";
        }

       public string Mensagem(){
           return "Mensagem Enviada";
       }
        

    }
}