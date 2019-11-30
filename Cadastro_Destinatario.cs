using System;
using System.Collections.Generic;
using System.Text;

namespace FLORICULTURA
{
   public class Cadastro_Destinatario : Cadastro_Cliente
    {

        public string NomeDestinatario { get; set; }
       
                
        // Endereco Entrega Destinatario

        public string EnderecoEntrega{ get; set; }
        public string NumeroEndEntrega { get; set; }
        public string ComplementoEndEntrega { get; set; }
        public string BairroEndEntrega { get; set; }

        
    }
}
