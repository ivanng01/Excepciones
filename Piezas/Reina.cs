using Excep.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excep.Piezas
{
    public class Reina : IPieza
    {

        public int tamaño = 8;
        public string nombrePieza = "Reina";

        public bool PosicOk(int f, int c, Disposicion[][] tabJuego)
        {
            for (int i = 0; i < f; i++)
            {
                /* Compruebo si ya hay una reina en la misma c */
                if (tabJuego[i][c] == Disposicion.P)
                {
                    return false;
                }

                /* Compruebo diag*/
                // Verificar diagonal superior izquierda
                if (c - (f - i) >= 0 && tabJuego[i][c - (f - i)] == Disposicion.P)
                {
                    return false;
                }

                /* Compruebo diag*/
                if (c + (f - i) < tamaño && tabJuego[i][c + (f - i)] == Disposicion.P)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
