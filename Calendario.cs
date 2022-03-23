using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDeProg
{
    public class Calendario
    {
        private UInt16 ano {get;set;}

        private Byte mes {get;set;}



        public Calendario(UInt16 _ano, Byte _mes)
        {
            _ano = _ano;
            _mes = _mes;
        }

        public Boolean IsMesValido()
        {
            if (mes > 0 && mes < 13)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public Boolean IsAnoValido()
        {
            if (ano > 0 && mes < 1000)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public String GerarCalendario()
        {
            return "Não sei fazer issokkk";
        }


    }
}
