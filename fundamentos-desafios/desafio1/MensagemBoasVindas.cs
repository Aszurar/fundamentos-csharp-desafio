namespace FundamentosDesafio.desafio1;

public class MensagemBoasVindas
{
    public void Mensagem()
    {
        Console.WriteLine("Por fovor, digite seu nome: ");
        var nome = Console.ReadLine();


        Console.WriteLine($"Seja bem-vindo, {nome}!");
    }
}
