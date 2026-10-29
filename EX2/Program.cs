/* EX2 - Ações Multilíngues com Action<string>
Uma aplicação SaaS voltada ao público internacional precisa exibir mensagens de boas-
vindas em diferentes idiomas, conforme a configuração do cliente.

Tarefas:
Crie um programa de console em C#.
Solicite ao usuário que escolha um idioma (português, inglês ou espanhol).
Crie uma estrutura com Action<string> para exibir a mensagem de boas-vindas no idioma 
escolhido.
Implemente ao menos três versões de mensagens encapsuladas nos delegates.
Este exercício mostra como delegates com Action são úteis em interações que envolvem 
ações sem retorno, como feedback ao usuário.*/


using System;

namespace EX2
{
    internal class Program
    {

        public static void MsgPortugues(string usuario)
        {

            Console.WriteLine($"Seja bem-vindo {usuario}!");

        }

        public static void MsgIngles(string usuario)
        {

            Console.WriteLine($"Welcome {usuario}!");

        }

        public static void MsgEspanhol(string usuario)
        {

            Console.WriteLine($"¡Bienvenido {usuario}!");


        }

        static void Main(string[] args)
        {
            int opcao;
            string usuario;

            while (true)
            {
                Console.WriteLine("Qual o seu nome?");
                string? inputNome = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(inputNome))
                {
                    usuario = inputNome.Trim();
                    break;

                }

                Console.WriteLine("O nome não pode ser vazio.");

            }


            Console.WriteLine("Escolha o seu idioma: Ingles(1)/Português(2)/Espanhol(3)");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out opcao))
            {
                Console.WriteLine("Digite o número 1, 2 ou 3.");
                return;
            }

            Action<string> mensagemBoasVindas;

            switch (opcao)
            {
                case 1:
                    mensagemBoasVindas = MsgIngles;
                    break;

                case 2:
                    mensagemBoasVindas = MsgPortugues;
                    break;

                case 3:
                    mensagemBoasVindas = MsgEspanhol;
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    return;
            }

            mensagemBoasVindas(usuario);

        }
    }
}
