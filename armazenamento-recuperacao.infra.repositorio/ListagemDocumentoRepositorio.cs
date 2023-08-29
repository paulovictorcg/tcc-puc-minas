using armazenamento_recuperacao.Dominio.Interfaces;


namespace armazenamento_recuperacao.infra.repositorio
{
    public class ListagemDocumentoRepositorio : IListagemDocumentoRepositorio
    {
        public IEnumerable<Documentos> ListarDocumentos()
        {
            return Enumerable.Range(1, 5).Select(index => new Documentos
            {
                DataAlteracao = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(1, 55),
            })
            .ToArray();
        }
    }
}
