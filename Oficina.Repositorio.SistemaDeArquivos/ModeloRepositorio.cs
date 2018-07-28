using Oficina.Dominio;
using Oficina.Repositorio.SistemaDeArquivos.Dados;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oficina.Repositorio.SistemaDeArquivos
{
    public class ModeloRepositorio
    {
        XDocument _arquivoXML =  XDocument.Load(ConfigurationManager.AppSettings["caminhoArquivoModelo"]);

        public List<Modelo> SelecionarPorMarca(int marcaID)
        {
            var modelos = new List<Modelo>();
            foreach (var elemento in _arquivoXML.Descendants("modelo"))
            {
                if (elemento.Element("marcaId").Value == marcaID.ToString()) 
                {
                    var modelo = new Modelo();
                    modelo.Id = Convert.ToInt32(elemento.Element("id").Value);
                    modelo.Descricao = elemento.Element("nome").Value;
                    modelo.Marca = new MarcaRepositorio().Selecionar(marcaID);
                    modelos.Add(modelo);
                }
            }
            return modelos;
        }

        public Modelo Selecionar(int modeloID)
        {
            Modelo modelo = null;

            foreach (var elemento in _arquivoXML.Descendants("modelo"))
            {
                if (elemento.Element("id").Value == modeloID.ToString())
                {
                    modelo = new Modelo();
                    modelo.Id = Convert.ToInt32(elemento.Element("id").Value);
                    modelo.Descricao = elemento.Element("nome").Value;

                    var marcaID = Convert.ToInt32(elemento.Element("marcaId").Value);
                    modelo.Marca = new MarcaRepositorio().Selecionar(marcaID);
                    break;
                }
            }
            return modelo;
        }

    }
}
