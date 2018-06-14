using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_base_dados.Model
{
    class Funcionario
    {
        public int FUNCIONARIO_ID { get; set; }
        public string FUNCIONARIO_NOME { get; set; }
        public DateTime FUNCIONARIO_INICIO_CONTACTO { get; set; }
        public DateTime FUNCIONARIO_VALIDADE_CONTACTO { get; set; }
        public string FUNCIONARIO_BI { get; set; }
        public string CLIENTE_NIF { get; set; }
        public long FUNCIONARIO_SALARIO { get; set; }
        public int CARGO_ID { get; set; }
    }
    public class FuncionarioMoradaContacto
    {
        public int FUNCIONARIO_ID { get; set; }
        public string FUNCIONARIO_NOME { get; set; }
        public DateTime FUNCIONARIO_INICIO_CONTACTO { get; set; }
        public DateTime FUNCIONARIO_VALIDADE_CONTACTO { get; set; }
        public string FUNCIONARIO_BI { get; set; }
        public string CLIENTE_NIF { get; set; }
        public long FUNCIONARIO_SALARIO { get; set; }
        public int CARGO_ID { get; set; }
        public int MORADA_ID { get; set; }
        public int CC_ID { get; set; }
        public string RUA { get; set; }
        public string TIPO_CONTACTO { get; set; }
        public string VALOR { get; set; }
    }
}