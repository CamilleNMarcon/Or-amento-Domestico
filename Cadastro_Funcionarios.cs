using System;
using System.Collections.Generic;
using System.Text;

namespace FLORICULTURA
{
    public class Cadastro_Funcionarios : Cadastro
    {
        
               
        // Dados do Trabalho

        public Cargo CargoFuncionario { get; set; }
        public DateTime DataEntradaFuncionario { get; set; }
        public double SalarioFuncionario { get; set; }

        // Dados Conta Bancaria
        public string Banco { get; set; }
        public string ContaCorrenteFuncionario { get; set; }
        public string AgenciaFuncionario { get; set; }
        
              
    }

    
    public enum Cargo
    {
        Caixa,
        Vendedor,
        Entragador,
        Gerente,
        Faxineiro,
        Jardineiro
    }
}

