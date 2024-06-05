// See https://aka.ms/new-console-template for more information

using fundamentos_desafios.desafio2;
using fundamentos_desafios.desafio3;
using fundamentos_desafios.desafio4;
using fundamentos_desafios.desafio5;
using fundamentos_desafios.desafio6;
using FundamentosDesafio.desafio1;

namespace FundamentosDesafio
{
    class Program
    {
        static void Main() {
            Console.WriteLine("Desafio 1");
             var mensagemBoasVindas = new MensagemBoasVindas();
             mensagemBoasVindas.Mensagem();

            Console.WriteLine("\n");

            Console.WriteLine("Desafio 2");
            var concatenarNomeSobrenome = new ConcatenarNomes();
            concatenarNomeSobrenome.ConcatenarNomeSobrenome();
        
            Console.WriteLine("\n");

            Console.WriteLine("Desafio 3");
            var calculadora = new Calculadora();
            calculadora.Calcular();

            Console.WriteLine("\n");
            
            Console.WriteLine("Desafio 4");
            var quantidadeCaracter = new QuantidadeCaracter();
            quantidadeCaracter.ContarCaracteresSimples();
            quantidadeCaracter.ContarCaracteresComplexo();

            Console.WriteLine("\n");

            Console.WriteLine("Desafio 5");
            var placa = new PlacaCarro();
            placa.ValidarPlaca();

            Console.WriteLine("\n");

            Console.WriteLine("Desafio 6");
            var dataAtual = new DataAtual();
            dataAtual.MostrarDataAtual();
        }
    }
}