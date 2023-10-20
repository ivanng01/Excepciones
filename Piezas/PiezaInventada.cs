using Excep.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excep.Piezas
{
    public class PiezaInventada : IPieza
    {
        public int tamaño = 8;
        public string nombrePieza = "ABC";


        public bool PosicOk(int f, int c, Disposicion[][] tabJuego)
        {

            for (int i = 0; i < f; i++)
            {
                if (tabJuego[i][c] == Disposicion.P)
                {
                    return false;
                }

                if (c - (f - i) >= 0 && tabJuego[i][c - (f - i)] == Disposicion.P)
                {
                    return false;
                }

                if (c + (f - i) < tamaño && tabJuego[i][c + (f - i)] == Disposicion.P)
                {
                    return false;
                }

                if (tabJuego[i][c] != Disposicion.P)
                {
                    return false;  /*mov invent*/
                }
            }
            return true;
        }
    }
}
