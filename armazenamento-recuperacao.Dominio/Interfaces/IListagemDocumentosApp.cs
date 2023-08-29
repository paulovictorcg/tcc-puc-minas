
namespace armazenamento_recuperacao.Dominio.Interfaces
{
    public interface IListagemDocumentosApp
    {
        IEnumerable<Documentos> ObterDocumentos();
    }
}
