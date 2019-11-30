using System;
using System.Collections.Generic;
using System.Text;

namespace FLORICULTURA
{
    public class Cadastro_Cliente : Cadastro
    {


        public string Profissao { get; set; }
        
        public PagamentoCliente Pagar { get; set; }

        public Parcelas Vezes { get; set; }

        public enum PagamentoCliente
        {
            Credito,
            Debito
        }

        public enum Parcelas
        {
            nada,
            avista,
            duas,
            tras,
            quatro
        }
    }
}
