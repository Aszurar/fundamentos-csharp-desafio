namespace fundamentos_desafios.desafio3;

public class Calculadora
{
    public void Calcular()
    {
        Console.WriteLine("Digite o primeiro número: ");
        var primeiroNumero = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        var segundoNumero = Convert.ToDouble(Console.ReadLine());

        var soma = primeiroNumero + segundoNumero;
        var subtracao = primeiroNumero - segundoNumero;
        var multiplicacao = primeiroNumero * segundoNumero;
        var media = (primeiroNumero + segundoNumero) / 2;


        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");

        if (segundoNumero == 0)
            Console.WriteLine("Não é possível dividir por zero.");
        else
        {
            var divisao = primeiroNumero / segundoNumero;
            Console.WriteLine($"Divisão: {divisao.ToString("F2")}");

            Console.WriteLine($"Média: {media}");
        }

    }

}
