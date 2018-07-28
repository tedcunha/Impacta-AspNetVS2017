using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorio.SistemaDeArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorio.SistemaDeArquivos.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        [TestMethod()]
        public void InserirTeste()
        {
            var veiculo = new Veiculo();

            //veiculo.Id = 1;
            veiculo.Ano = 2018;
            veiculo.Cambio = Cambio.Altomatico;
            veiculo.Combustivel = Combustivel.Flex;
            veiculo.Cor = new CorRepositorio().Selecionar(1);
            veiculo.Modelo = new ModeloRepositorio().Selecionar(3);
            veiculo.Obs = "teste de inserir veiuclo";
            veiculo.Placa = "JPP-2861";

            new VeiculoRepositorio().Inserir(veiculo);
        }
    }
}