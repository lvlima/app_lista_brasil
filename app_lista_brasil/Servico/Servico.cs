using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using app_lista_brasil.Modelo;
using Newtonsoft.Json;

namespace app_lista_brasil.Servico
{
    public class Servico
    {
        private static string URLEstado = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";
        private static string URLMunicipio = "http://servicodados.ibge.gov.br/api/v1/localidades/estados/{0}/municipios";

        public Servico()
        {
        }

        public static List<Estado> listarEstados()
        {
            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(URLEstado);

            return JsonConvert.DeserializeObject<List<Estado>>(conteudo);
        }

        public static List<Municipio> listarMunicipio(int uf)
        {
            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(string.Format(URLMunicipio, uf));

            return JsonConvert.DeserializeObject<List<Municipio>>(conteudo);
        }
    }
}
