using System;
using System.Collections.Generic;
using System.Text;

namespace PorcentajeDeVaronesYMujeres
{
    class CalculoDePorcentajes
    {
        
        public decimal PorcentajeDeVarones (decimal TotalDeVarones, decimal TotalAlumnos)
        {
            return (TotalDeVarones * 100)/TotalAlumnos;
        }
        public decimal PorcentajeDeMujeres(decimal TotalDeMujeres, decimal TotalAlumnos)
        {
            return (TotalDeMujeres * 100) / TotalAlumnos;
        }
    }
}
