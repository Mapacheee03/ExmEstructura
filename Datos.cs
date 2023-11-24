using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Nodo
{
    public int valor { get; set; }
    public Nodo Siguiente { get; set; }


    public Nodo(int valor)
    {
        valor = valor;
        Siguiente = null;
    }
}
