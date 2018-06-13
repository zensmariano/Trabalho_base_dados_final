using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_base_dados.Model
{
    public class Cliente
    {
        public int CLIENTE_ID { get; set; }
        public string CLIENTE_NOME { get; set; }
        public string CLIENTE_NIF { get; set; }
        public DateTime CLIENTE_DATA_1_CONTACTO { get; set; }
    }
}
