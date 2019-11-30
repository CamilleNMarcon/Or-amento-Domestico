using System;


namespace FLORICULTURA
{
    public class Cadastro : FloriculturaDaCa
    {

        // Tipo de Cadastro:

        public string Nome { get; set; }
        public DateTime DataDeNascimento{ get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        // Endereco Cliente

        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }


        public Sou Id { get; set; }

                         
            public enum Sou
            {
            Cliente,
            Funcionario
            }


    }
}
