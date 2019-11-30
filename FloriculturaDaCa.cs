using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FLORICULTURA
{
    public class FloriculturaDaCa
    {
        static void Main(string[] args)
        {
            Cadastro FloriculturaDaCa = new Cadastro();

            Console.WriteLine("Bem-Vindo(a)! Aqui é a Floricultura da Ca! Preencha os dados abaixo para se cadastrar:");
            Cadastrar();
        }

        public static void Cadastrar()
        {
            //CADASTRO GERAL

            Console.WriteLine("* Nome:");
            string Nome = Console.ReadLine();

            Console.WriteLine("* Email:");
            string Email = Console.ReadLine();

            Console.WriteLine("* Telefone:");
            string Telefone = (Console.ReadLine());

            Console.WriteLine("* Data de Nascimento:");
            DateTime DataDeNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("* CPF:");
            string CPF = Console.ReadLine();

            Console.WriteLine("* Endereco, Numero, Complemento e Bairro ");
            string[] vetores = Console.ReadLine().Split(' ');
            string Endereco = vetores[0];
            string Numero = vetores[1];
            string Complemento = vetores[2];
            string Bairro = vetores[3];
            
            // QUEM ESTA SE CADASTRANDO É NOVO CLIENTE OU NOVO FUNCIONARIO?

            Console.WriteLine("* Você é novo Cliente ou novo Funcionario?");
            string Id = Console.ReadLine().ToLower();

            if (Id == "funcionario")
            {
                Console.WriteLine("* Data da Contratacao:");
                DateTime DataEntradaFuncionario = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("* Cargo:");
                string CargoFuncionario = (Console.ReadLine());

                Console.WriteLine("* Salario:");
                double SalarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("* Banco, Agencia, Conta Corrente: ");
                vetores = Console.ReadLine().Split(' ');
                string Banco = vetores[0];
                string AgenciaFuncionario = vetores[1];
                string ContaCorrenteFuncionario = vetores[2];

                Console.WriteLine("* Cadastro de Funcionario Realizadolizado! Obrigado!");

            }
            else if (Id == "cliente")
            {

                // CLIENTE: Encomenda + Cadastro Destinatario + Forma de Pagamento
                                
                string Resposta = "Sim";

                Flores minhasFlores = new Flores();
                minhasFlores.PreencherFlores();
                double valorDaVenda = 0;
                
                do
                {
                    Console.WriteLine("* Adicione abaixo o nome da flor(es) que você Gostaria de Comprar: ");
                    Console.WriteLine("* Opções / Valor Unidade:");
                    Console.WriteLine(" - rosa = R$ 8.0");
                    Console.WriteLine(" - lirios = R$ 15.0");
                    Console.WriteLine(" - margaridas = R$ 10.0");
                    Console.WriteLine(" - cravos  = R$ 20.0");
                    Console.WriteLine(" - orquideas = R$ 15.0");
                    Console.WriteLine(" - gerberas = R$ 9.5");
                    Console.WriteLine(" - lisianthus = R$ 7.0");
                    Console.WriteLine(" - astromelias = R$ 7.5");

                    string nome = Console.ReadLine().ToLower();

                    double valor = minhasFlores.FloresNoSistema[nome];
                                                                             
                    Console.WriteLine("* Adicione a Quantidade da flor:");
                    int quantidade = int.Parse(Console.ReadLine());

                    valorDaVenda += quantidade * valor;

                    Console.WriteLine("* O Valor da sua Compra é de: R$" + valorDaVenda);
                    Console.WriteLine("  Gostaria de adicionar mais algum tipo de flor? (sim / não):");
                    Resposta = Console.ReadLine().ToLower();
                   
                }
                while (Resposta == "sim");

                Console.WriteLine("* Informe o Dia e Horario para a Entrega:");
                vetores = Console.ReadLine().Split(' ');
                DateTime DataEntrega = DateTime.Parse(vetores[0]);
                DateTime HorarioDeEntrega = DateTime.Parse(vetores[1]);

                // DADOS DO DESTINATARIO:

                Console.WriteLine("* Informe o Nome do Destinatario:");
                string NomeDestinatario = Console.ReadLine();

                Console.WriteLine("* Endereco, Numero, Complemento e Bairro de Entrega: ");
                vetores = Console.ReadLine().Split(' ');
                string EnderecoEntrega = vetores[0];
                string NumeroEndEntrega = vetores[1];
                string ComplementoEndEntrega = vetores[2];
                string BairroEndEntrega = vetores[3];

                Console.WriteLine("* Escreva uma mensagem para acompanhar as flores:");
                string Mensagem = Console.ReadLine();

                // FORMA DE PAGAMENTO:

                Console.WriteLine("* Para finalizar a compra preencha abaixo os dados de pagamento: ");
                Console.WriteLine("* Nome do Cartão:");
                string NomeCartao = (Console.ReadLine());

                Console.WriteLine("* Numero do Cartão:");
                string NumeroCartao = Console.ReadLine();

                Console.WriteLine("* Informe a Data de Validade do Cartão:");
                DateTime ValidadeCartao = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("* Informe a Senha do Cartão:");
                string SenhaCartao = Console.ReadLine();

                // CADASTRO_CLIENTE:

                Console.WriteLine("* Deseja pagar em Cartão de Credito ou Debito?:");
                string PagamentoCliente = Console.ReadLine().ToLower();

                if (PagamentoCliente == "credito")
                {
                    Console.WriteLine("* Informe o numero de Parcelas (em até 4x sem juros):");
                    int Parcelas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ola " + Nome + "! Sua compra de: R$ " + valorDaVenda + " em " + Parcelas + "x sem juros, foi Realizada com sucesso e será entregue para: " + NomeDestinatario + " em " + HorarioDeEntrega + ".");
                    Console.WriteLine("Obrigado(a) por comprar conosco!");
                    Console.ReadLine();
                }
                else if (PagamentoCliente == "debito")
                {
                    Console.WriteLine("Ola " + Nome + "! Sua compra de: R$ " + valorDaVenda + ", foi Realizada com sucesso e será entregue para: " + NomeDestinatario + " em " + HorarioDeEntrega + ".");
                    Console.WriteLine("Obrigado(a) por comprar conosco!");
                    Console.ReadLine();
                }
            }
        }
    }
}







