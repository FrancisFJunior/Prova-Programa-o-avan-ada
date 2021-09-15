using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_1_PraogramacaoAvc
{
    class Concessionaria
    {
        protected string _localizacao;
        protected string _gerentePrincipal;
        protected int _anoFundacao;
        List<Carro> carrosDisponiveis = new List<Carro>();

        public void adicionaCarro(Carro x)
        {
            carrosDisponiveis.Add(x);
        }

        public void calcularPortifolio()
        {
            double somaVeiculos = 0;

            for (int x = 0; x < carrosDisponiveis.Count; x++)
            {
                somaVeiculos = somaVeiculos + carrosDisponiveis[x].getValor();
            }

            Console.WriteLine(somaVeiculos);
        }

    }
}
