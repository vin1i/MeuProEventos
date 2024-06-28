namespace MeuProEvento.API.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string? Local { get; set; }
        public string? DataEvento { get; set; }
        public string? Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string? Lote { get; set; }
        public string? ImagemURL { get; set; }
    }
}



/* Dessa forma abaixo, é gerado um aviso que as strings não estão sendo anuláveis. Se trata mais de boas práticas.*/
// namespace MeuProEvento.API.Models
// {

// public class Evento
// {
//     public int EventoId {get; set;}

//     public string Local {get; set;}

//     public string DataEvento {get; set;}
//     public string Tema {get; set;}

//     public int  QtdPessoas {get; set;}

//     public string Lote {get; set;}

//     public string ImagemURL {get; set;}
// }
// }
