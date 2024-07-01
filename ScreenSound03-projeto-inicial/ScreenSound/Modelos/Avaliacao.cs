using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        if (nota < 0)
        {
            Nota = 0;
        }
        else if (nota > 10)
        {
            Nota = 10;
        }
        else
        {
            Nota = nota;
        }
    }

    public int Nota { get; }

    public static Avaliacao Parse(string texto) 
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
