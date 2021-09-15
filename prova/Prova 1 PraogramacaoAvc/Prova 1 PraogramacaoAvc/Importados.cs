using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_1_PraogramacaoAvc
{
    class Importados : Carro
    {

        protected override void definirValorFixo(double custoFixo)
        {
            _valor = (custoFixo * 3.0) + (0.6 * custoFixo) + (custoFixo / 5);
        }

    }
}
