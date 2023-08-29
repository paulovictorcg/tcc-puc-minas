using armazenamento_recuperacao.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace armazenamento_recuperacao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListarDocumentosController : ControllerBase
    {
        private readonly IListagemDocumentosApp _listagemDocumentosApp;
        private readonly ILogger<ListarDocumentosController> _logger;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        public ListarDocumentosController(IListagemDocumentosApp listagemDocumentosApp, ILogger<ListarDocumentosController> logger)
        {
            _logger = logger;
            _listagemDocumentosApp = listagemDocumentosApp;
        }

        [HttpGet]
        public IEnumerable<Documentos> Get()
        {
            return _listagemDocumentosApp.ObterDocumentos();
        }
    }
}