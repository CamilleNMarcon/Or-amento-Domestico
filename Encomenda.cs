using System;
using System.Collections.Generic;


namespace FLORICULTURA
{
    public class Encomenda : Cadastro_Cliente

    {
        public int Quantidade { get; set; }
        

        
        // COMPRA:

        public double valorDaVenda { get; set; }
        public DateTime DataEntrega { get; set; }
        public DateTime HorarioDeEntrega { get; set; }
        public string Mensagem { get; set; }

        

        
    }
   

}



