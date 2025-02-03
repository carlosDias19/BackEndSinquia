using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.SinquiaContext
{
    public class PontoTuristico
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? UF { get; set; }
        public string? Cidade { get; set; }
        public string Referencia { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataInclusao { get; set; }

    }
}
