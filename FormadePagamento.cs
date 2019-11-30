using System;
using System.Collections.Generic;
using System.Text;

namespace FLORICULTURA
{
    public class FormadePagamento : Encomenda
    {
        // Informacao Cartao

        public string NomeCartao { get; set; }
        public string NumeroCartao { get; set; }
        public string SenhaCartao { get; set; }
        public DateTime ValidadeCartao { get; set; }

    }
}
