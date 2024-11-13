using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppHotel.Models
{
    public class Quarto
    {
        public string Descricao {  get; set; } // você poderá tanto pegar os dados como definí-los
        public double ValorDiariaAdulto { get; set; }
        public double ValorDiariaCrianca { get; set; }
        
    }
}
