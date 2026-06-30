namespace Abstracciones.Modelos
{
    public class PostalBase
    {
        public int Numero { get; set; }
        public string Posicion { get; set; } = string.Empty;
        public bool Tengo { get; set; }
        public string Notas { get; set; } = string.Empty;
    }

    public class PostalRequest : PostalBase
    {
        public Guid IdPais { get; set; }
        public Guid IdGrupo { get; set; }
    }

    public class PostalResponse : PostalBase
    {
        public Guid Id { get; set; }
        public string Pais { get; set; } = string.Empty;
        public string Grupo { get; set; } = string.Empty;
        public DateTime FechaAgregada { get; set; }
    }
}