public class Prenotazione{

   
    public string? Nome { get; set; }

    public string? Cognome { get; set; }

    public string? Email { get; set; }
     
    public DateTime Data { get; set; }

    public Sesso _Sesso { get; set; }

    public Ruolo _Ruolo { get; set; }

    public enum Sesso{
        Maschio,
        Femmina,
        NonSpecificato,
    }

    public enum Ruolo{
        Insegnante,
        Studente,
        Genitore,    
    }
}