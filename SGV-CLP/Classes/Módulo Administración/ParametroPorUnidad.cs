using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    public class ParametroPorUnidad
    {
        public string? IdParametro { get; set; }
        public string? UnidadBase { get; set; }
        public string? UnidadExtra { get; set; }
        public string? Producto { get; set; }

        public ParametroPorUnidad(string? idParametro, string? unidadBase, string? unidadExtra, string? producto)
        {
            IdParametro = idParametro;
            UnidadBase = unidadBase;
            UnidadExtra = unidadExtra;
            Producto = producto;
        }
    }
}
