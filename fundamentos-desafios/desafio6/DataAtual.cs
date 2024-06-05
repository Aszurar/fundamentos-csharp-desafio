namespace fundamentos_desafios.desafio6;

public class DataAtual
{
    public void MostrarDataAtual()
    {
        var dataAtualComHorario = DateTime.Now;
        
        Console.WriteLine($"Data e hora atual com horário completo: {dataAtualComHorario}");
        Console.WriteLine($"Data atual sem horário: {dataAtualComHorario.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Somente a hora atual: {dataAtualComHorario.Hour} horas");
        Console.WriteLine($"Somente o mês por exetenso: {dataAtualComHorario.ToString("MMMM")}");

    }
}
