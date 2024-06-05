namespace fundamentos_desafios.desafio4;

public class QuantidadeCaracter
{
    public void ContarCaracteresSimples()
    {
        Console.WriteLine("Digite uma frase: Contador Simples ");
        var frase = Console.ReadLine();

        Console.WriteLine("É para considerar espaços em branco? (S/N)");
        var considerarEspacos = Console.ReadLine();

        var quantidadeCaracteres = 0;

        if(frase != null)
        {
            var considerarEspacoFormatado = considerarEspacos != null ? considerarEspacos.ToUpper() : "N";
            var fraseFormatada = considerarEspacos == "S" ? frase : frase.Trim();
            quantidadeCaracteres = fraseFormatada.Length;

        }



        Console.WriteLine($"A frase digitada possui {quantidadeCaracteres} caracteres.");
    }

    public void ContarCaracteresComplexo()
    {
        Console.WriteLine("Digite uma frase: Contador Complexo");
        var frase = Console.ReadLine();

        Console.WriteLine("É para considerar espaços em branco? (S/N)");
        var considerarEspacos = Console.ReadLine();

        var contador = 0;



        if (frase != null)
        {
            var considerarEspacoFormatado = considerarEspacos != null ? considerarEspacos.ToUpper() : "N";

            for (int i = 0; i < frase.Length; i++)
            {
                if(considerarEspacoFormatado == "N" && frase[i] == ' ') continue;
                    contador++;
            }
        }


        Console.WriteLine($"A frase digitada possui {contador} caracteres.");
        
    }
}
