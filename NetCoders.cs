using HtmlAgilityPack;

namespace WebCrawler_JusBrasil
{
    public class NetCoders
    {
        // carrega a pagina HTML da URL fornecida
        public HtmlAgilityPack.HtmlDocument CarregarPagina(string url)
        {
            var web = new HtmlWeb();
            return web.Load(url); // retorna pagina carregada
        }
    }
}