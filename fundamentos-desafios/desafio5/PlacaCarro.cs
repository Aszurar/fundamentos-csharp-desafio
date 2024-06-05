namespace fundamentos_desafios.desafio5;

public class PlacaCarro
{
    public void ValidarPlaca() {
        var ehValida = false;

        do
        {
            Console.WriteLine("Digite a placa do carro: ");
            var placa = Console.ReadLine();

            var placeEhString = placa != null;
            if (placeEhString == false)
            {
                Console.WriteLine("Placa inválida, não foi PREENCHIDA CORRETAMENTE. Tente novamente.");
                continue;
            }

            var quantidadeCaracteresEhValida = placa.Length == 7;
            if (quantidadeCaracteresEhValida == false)
            {
                Console.WriteLine("Placa inválida, a quantidade de caracteres É DIFERENTE DE 7. Tente novamente.");
                continue;
            }

            var tresPrimeirasCaracteres = placa.Substring(0, 3);
            var ehLetra = false;
            foreach (var caracter in tresPrimeirasCaracteres)
            {
                ehLetra = char.IsLetter(caracter);
                if (ehLetra == false)
                {
                    Console.WriteLine("Placa inválida, os três primeiros caracteres DEVEM SER LETRAS. Tente novamente.");
                    break;
                }
            }

            var quatrosUltimosCaracteres = placa.Substring(3, 4);
            var ehNumero = false;
            foreach (var caracter in quatrosUltimosCaracteres)
            {
                ehNumero = char.IsDigit(caracter);
                if (ehNumero == false)
                {
                    Console.WriteLine("Placa inválida, os quatro últimos caracteres DEVEM SER NÚMEROS. Tente novamente.");
                    break;
                }
            }

            ehValida = ehLetra && ehNumero && quantidadeCaracteresEhValida && placeEhString;

            if (ehValida)
            {
                Console.WriteLine("Placa válida.");
            }

        } while (ehValida != true);
    
    }
}
