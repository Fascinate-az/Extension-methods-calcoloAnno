public static class Data
{
   
    //public static DateTime dataDiNascita = new DateTime(1992,4,10);
    
    public static string CalcoloTempoDallaNascita(this string input,DateTime dataDiNascita) // per usarlo come estensione del metodo string, altrimenti rimuovere le static e il paramentro con this
    {
        var tempoTrascordo = DateTime.Now - dataDiNascita;
        var annoInserito = dataDiNascita.Year;
        var CalcoloAnno = DateTime.Now.Year - annoInserito;
        

        if (DateTime.Now.Month < dataDiNascita.Month ||(DateTime.Now.Month == dataDiNascita.Month&&DateTime.Now.Day < dataDiNascita.Day))
        {
            CalcoloAnno--;

        }
        
        else if (DateTime.Now.Day == dataDiNascita.Day && DateTime.Now.Month == dataDiNascita.Month)
        {
            return
                $"Auguri è il tuo compleanno!!!!!\nSono trascorsi {tempoTrascordo.Days} giorni ,{tempoTrascordo.Hours} ore e {CalcoloAnno} anni";
        }
        return $"Sono trascorsi {tempoTrascordo.Days} giorni ,{tempoTrascordo.Hours} ore e {CalcoloAnno  } anni ";
    }
}
