using armazenamento_recuperacao.aplicacao;
using armazenamento_recuperacao.Dominio.Interfaces;
using armazenamento_recuperacao.infra.repositorio;
using Microsoft.Extensions.DependencyInjection;


namespace armazenamento_recuperacao.infra.IoC
{
    public static class IoC
    {
        public static void AddAplicacao(this IServiceCollection service)
        {
            service.AddScoped<IListagemDocumentosApp, ListagemDocumentosApp>();
            
        }
        public static void AddRepositorio(this IServiceCollection service)
        {
            service.AddScoped<IListagemDocumentoRepositorio, ListagemDocumentoRepositorio>();
            
        }
    }
}
