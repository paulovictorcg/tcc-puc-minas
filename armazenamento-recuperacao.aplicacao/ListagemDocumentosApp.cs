using armazenamento_recuperacao.Dominio.Interfaces;

namespace armazenamento_recuperacao.aplicacao
{
    public class ListagemDocumentosApp : IListagemDocumentosApp
    {
        private readonly IListagemDocumentoRepositorio _listagemDocumentoRepositorio;
        public ListagemDocumentosApp(IListagemDocumentoRepositorio listagemDocumentoRepositorio)
        {
            _listagemDocumentoRepositorio = listagemDocumentoRepositorio;
        }
        public IEnumerable<Documentos> ObterDocumentos()
        {
            return _listagemDocumentoRepositorio.ListarDocumentos();
        }
    }
}
