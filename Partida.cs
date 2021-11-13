using System;
using System.Collections.Generic;
using System.Text;

namespace Dado
{
    class Partida
    {
        List<Dado> listaDados;

        public void ComenzarPartida(int cantidadDados)
        {
            listaDados = new List<Dado>();
            for (int i = 0; i < cantidadDados; i++)
            {
                listaDados.Add(new Dado());
            }

            foreach (Dado dadoDeMiPartida in this.listaDados)
            {
                dadoDeMiPartida.Tirar();
            }
        }

        public bool Perdi()
        {
            foreach (Dado dadoX in listaDados)
            {
                foreach (Dado dadoY in listaDados)
                {
                    if (dadoX == dadoY)
                        continue;
                    if (dadoX.Numero == dadoY.Numero)
                        return true;
                }
            }
            return false;
        }
    }
}