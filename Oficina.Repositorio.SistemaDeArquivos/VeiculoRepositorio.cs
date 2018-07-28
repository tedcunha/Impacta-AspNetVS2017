using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Oficina.Repositorio.SistemaDeArquivos
{
    public class VeiculoRepositorio
    {
        private string _caminhoArquivo;
        private XDocument _arquivoXML;

        public VeiculoRepositorio()
        {
            _caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoVeiculo"];
            _arquivoXML = XDocument.Load(_caminhoArquivo);
        }

        public void Inserir(Veiculo veiculo)
        {
            var registro = new StringWriter();
            new XmlSerializer(typeof(Veiculo)).Serialize(registro, veiculo);

            _arquivoXML.Root.Add(XElement.Parse(registro.ToString()));
            _arquivoXML.Save(_caminhoArquivo);
        }
    }
}
