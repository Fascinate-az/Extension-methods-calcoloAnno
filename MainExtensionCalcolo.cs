public class Program
{
    public static void Main()
    {
        string CalcoloTempoTrascorso = "";
        DateTime inputGiorno = new DateTime();
        Console.WriteLine("Quando sei nato (giorno,mese,anno)?");
        var verifica = DateTime.TryParse(Console.ReadLine(), out inputGiorno);

        if (!verifica)
        {
            Console.WriteLine("errore nel formato");
            return;
        }
        

        Console.WriteLine(CalcoloTempoTrascorso.CalcoloTempoDallaNascita(inputGiorno));
    }
}
