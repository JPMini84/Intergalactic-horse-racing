using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseProject
{
    class ApostaCorrida
    {
        private List<Cavalo> listaCavalos;
        private string nomeApostador;
        private int valorApostado;

        public ApostaCorrida()
        {
            this.listaCavalos = new List<Cavalo>();
        }

        
        public string NomeApostador { get => nomeApostador; set => nomeApostador = value; }
        public int ValorApostado { get => valorApostado; set => valorApostado = value; }
        internal List<Cavalo> ListaCavalos { get => listaCavalos; }
    }
}
