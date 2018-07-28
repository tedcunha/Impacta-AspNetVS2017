using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace Oficina.Repositorio.SistemaDeArquivos
{
    public class CorRepositorio
    {
        private string _caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoCor"];

        public List<Cor> SelecionarTodos()
        {
            var cores = new List<Cor>();

            foreach (var linha in File.ReadAllLines(_caminhoArquivo))
            {
                var cor = new Cor();
                cor.Id = Convert.ToInt32(linha.Substring(0, 5));
                cor.Descricao = linha.Substring(5);

                cores.Add(cor);
            }
            return cores.OrderBy(x => x.Id).ToList();
        }

        public List<Cor> Selecionar()
        {
            var cores = new List<Cor>();

            foreach(var linha in File.ReadAllLines(_caminhoArquivo))
            {
                var cor = new Cor();
                cor.Id = Convert.ToInt32(linha.Substring(0, 5));
                cor.Descricao = linha.Substring(5);

                cores.Add(cor);
            }
            return cores.OrderBy(x => x.Id).ToList();
        }

        public Cor Selecionar(int corID)
        {
            Cor cor = null;

            foreach (var linha in File.ReadAllLines(_caminhoArquivo))
            {
                var linhaID = Convert.ToInt32(linha.Substring(0, 5));
                if (linhaID == corID)
                {
                    cor = new Cor();
                    cor.Id = Convert.ToInt32(linha.Substring(0, 5));
                    cor.Descricao = linha.Substring(5);
                    break;
                }
            }

            return cor;
        }
    }
}
