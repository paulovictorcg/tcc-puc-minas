namespace armazenamento_recuperacao
{
    public class Documentos
    {
        public DateTime DataAlteracao { get; set; }

        public int TemperatureC { get; set; }

        public string nomeDocumento => "nome-documento." + Random.Shared.Next(1, 55);

        public string? Summary { get; set; }
    }
}