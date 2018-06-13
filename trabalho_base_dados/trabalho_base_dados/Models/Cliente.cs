using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_base_dados
{
    public class Cliente
    {
        #region Variáveis
        private int cliente_ID;
        private string cliente_Nome;
        private string cliente_Nif;
        private DateTime cliente_Data_1_Contacto;
        #endregion
        #region Propriedades
        public int Cliente_ID { get => cliente_ID; set => cliente_ID = value; }
        public string Cliente_Nome { get => cliente_Nome; set => cliente_Nome = value; }
        public string Cliente_Nif { get => cliente_Nif; set => cliente_Nif = value; }
        public DateTime Cliente_Data_1_Contacto { get => cliente_Data_1_Contacto; set => cliente_Data_1_Contacto = value; }
        #endregion
    }
}
