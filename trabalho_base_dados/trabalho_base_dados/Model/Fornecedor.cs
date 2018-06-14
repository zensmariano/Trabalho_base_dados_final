using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_base_dados.Model
{
    class Fornecedor
    {
        public int FORNECEDOR_ID { get; set; }
        public string FORNECEDOR_NOME { get; set; }
        public string FORNECEDOR_DESCRICAO { get; set; }  
        public string FORNECEDORE_NIF { get; set; }
    }
    public class fornecedorMoradaContacto
    {
        public int FORNECEDOR_ID { get; set; }
        public string FORNECEDOR_NOME { get; set; }
        public string FORNECEDOR_DESCRICAO { get; set; }
        public string FORNECEDORE_NIF { get; set; }
        public int MORADA_ID { get; set; }
        public int CC_ID { get; set; }
        public string RUA { get; set; }
        public string TIPO_CONTACTO { get; set; }
        public string VALOR { get; set; }
    }
}