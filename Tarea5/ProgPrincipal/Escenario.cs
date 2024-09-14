﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPrincipal
{
    [Serializable]
    public class Escenario
    {
        public Dictionary<string, Objeto> objetos;

        public Escenario()
        {
            objetos = new Dictionary<string, Objeto>();
        }

        public Escenario(Dictionary<string, Objeto> objeto)
        {
            objetos = objeto;
        }

        public void agregar(string clave, Objeto p)
        {
            objetos.Add(clave, p);
        }

        public void remover(string clave)
        {
            objetos.Remove(clave);
        }

        public void Escalar(float valor)
        {
            foreach (Objeto kvp in objetos.Values)
            {
                kvp.Escalar(valor);

            }
        }

        public void trasladar(Punto nc)
        {
            foreach (Objeto kvp in objetos.Values)
            {
                kvp.trasladar(nc);

            }
        }

        public void Dibujar()
        {
            foreach (Objeto valor in objetos.Values)
            {
                valor.Dibujar();
            }
        }
    }
}
