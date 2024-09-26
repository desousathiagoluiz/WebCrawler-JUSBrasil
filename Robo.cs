using System;
using System.Collections.Generic;
using System.Net.Http;
// adicionar o HtmlAgilityPack
using HtmlAgilityPack;

namespace WebCrawler_JUSBrasil
{
    public class Robo
    {
        private readonly HttpClient _httpClient;

        public Robo()
        {
            _httpClient = new HttpClient();
        }

        public List<string> BuscarProcessosPorCpf(string cpf)
        {
            var resultados = new List<string>();
            var url = $"https://www.jusbrasil.com.br/acompanhamentos/processos?cpf={cpf}";

            var response = _httpClient.GetStringAsync(url).Result;
            // HtmlDocument da HtmlAgilityPack
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(response);

            // utiliza o XPath correto para capturar os dados de processo
            var processoNodes = doc.DocumentNode.SelectNodes("//div[@class='resultado-processo']");

            if (processoNodes != null)
            {
                foreach (var node in processoNodes)
                {
                    var titulo = node.SelectSingleNode(".//h2").InnerText.Trim();
                    var resumo = node.SelectSingleNode(".//p").InnerText.Trim();
                    resultados.Add($"{titulo} - {resumo}");
                }
            }

            return resultados;
        }
    }
}