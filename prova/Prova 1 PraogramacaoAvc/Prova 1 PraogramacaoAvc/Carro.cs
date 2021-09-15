using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_1_PraogramacaoAvc
{
    class Carro
    {
        protected string _cor;
        protected string _marca;
        protected string _modelo;
        protected double _valor;
        protected int _anoFabricacao;

        public Carro()
        {

        }

        public Carro(string cor, double valor, int anoFabricacao)
        {
            this._cor = cor;
            this._valor = valor;
            this._anoFabricacao = anoFabricacao;
        }

        protected virtual void definirValorFixo(double custoFixo)
        {

        }

        public string getCor()
        {
            return _cor;
        }

        private void setCor(string cor)
        {
            this._cor = cor;
        }

        public double getValor()
        {
            return _valor;
        }

        private void setValor(double valor)
        {
            this._valor = valor;
        }

        public int getAnoFabricacao()
        {
            return _anoFabricacao;
        }

        private void setAnoFabricacao(int anoFabricacao)
        {
            this._anoFabricacao = anoFabricacao;
        }

    }
}
