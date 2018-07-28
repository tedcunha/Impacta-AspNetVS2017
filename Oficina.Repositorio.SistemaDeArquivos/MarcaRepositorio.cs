using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorio.SistemaDeArquivos.Dados
{
    public class MarcaRepositorio
    {
        private string _caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoMarca"];

        public List<Marca> SelecionarTodos()
        {
            var marcas = new List<Marca>();
            foreach (var linha in File.ReadAllLines(_caminhoArquivo))
            {
                var campos = linha.Split('|');

                var marca = new Marca();
                marca.Id = Convert.ToInt32(campos[0]);
                marca.Nome = campos[1];
                marcas.Add(marca);
            }
            return marcas;
        }

        public List<Marca> Selecionar()
        {
            var marcas = new List<Marca>();
            foreach (var linha in File.ReadAllLines(_caminhoArquivo))
            {
                var campos = linha.Split('|');
                var marca = new Marca();
                marca.Id = Convert.ToInt32(campos[0]);
                marca.Nome = campos[0];
                marcas.Add(marca);
            }
            return marcas;
        }

        public Marca Selecionar(int marcaID)
        {
            Marca marca = null;
            foreach (var linha in File.ReadAllLines(_caminhoArquivo))
            {
                var campos = linha.Split('|');
                if (campos[0] == marcaID.ToString())
                {
                    marca = new Marca();
                    marca.Id = Convert.ToInt32(campos[0]);
                    marca.Nome = campos[1];
                    break;
                }
            }
            return marca;
        }
    }
}
