public static class Data
{
   
    public static DateTime dataDiNascita = new DateTime(1992,4,10);
    

    public static string CalcoloTempoDallaNascita(this string input) // creata per estensione del metodo, rimuovere il this
    {
        var tempoTrascordo = DateTime.Now - dataDiNascita;
        var annoInserito = dataDiNascita.Year;
        var CalcoloAnno = DateTime.Now.Year - annoInserito;
        

        if (DateTime.Now.Month < dataDiNascita.Month ||(DateTime.Now.Month == dataDiNascita.Month&&DateTime.Now.Day < dataDiNascita.Day))
        {
            CalcoloAnno--;

        }
        return $"Sono trascorsi {tempoTrascordo.Days} giorni ,{tempoTrascordo.Hours} ore e {CalcoloAnno  } anni ";
    }
}
