using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excep.Interfaces
{
    public enum Disposicion
    {
        D = 0, //Posicion Desocupada
        P = 1,  //Posición Pieza
    }
    public interface IPieza
    {
        bool PosicOk(int f, int c, Disposicion[][] tabJuego);
    }
}
