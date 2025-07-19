using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckListInspecao
{
    public class Inspecao
    {
        public string Tecnico { get; set; }
        public DateTime Data { get; set; }
        public string Ccm { get; set; }
        public List<string> ItensVerificados { get; set; }
        public string Comentarios { get; set; }
        public override string ToString()
        {
            return $"Técnico: {Tecnico}\n" +
                $"Data: Data.ToShortDateString()\n" +
                $"CCM: {Ccm}\n" +
                $"Itens Verificados: {string.Join("\n -  ", ItensVerificados)}\n" +
                $"Comentários:\n{Comentarios}";
        }
    }
}
