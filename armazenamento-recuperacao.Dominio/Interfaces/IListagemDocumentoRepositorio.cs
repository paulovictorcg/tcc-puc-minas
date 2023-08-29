

namespace armazenamento_recuperacao.Dominio.Interfaces
{
    public interface IListagemDocumentoRepositorio
    {
        IEnumerable<Documentos> ListarDocumentos();
    }
}
