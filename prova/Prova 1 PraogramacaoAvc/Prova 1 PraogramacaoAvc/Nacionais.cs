using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_1_PraogramacaoAvc
{
    class Nacionais : Carro
    {

        protected virtual void definirValorFixo(double custoFixo)
        {
            _valor = (custoFixo * 1.5) + (0.2 * custoFixo) + (custoFixo / 10);
        }

    }
}
