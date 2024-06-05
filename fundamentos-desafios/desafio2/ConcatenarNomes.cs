namespace fundamentos_desafios.desafio2;

public class ConcatenarNomes
{
    public void ConcatenarNomeSobrenome()
    {
        Console.WriteLine("Por favor, digite seu nome: ");
        var nome = Console.ReadLine();

        Console.WriteLine("Agora, digite seu sobrenome: ");
        var sobrenome = Console.ReadLine();

        Console.WriteLine($"Seja bem-vindo, {nome} {sobrenome}!");
    }
}
