using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Runtime;



namespace AppFinanceiro {
    class FormLancamentos : FormContas {

        static List<FormLancamentos> FormLancamento = new List<FormLancamentos>();
        static int MaxIdL = 0;

        private int _IdL;
        private DateTime _Data;
        private double _Valor;
        private string _Descricao;

        #region Acesso a Dados

        public int IdL {
            set { _IdL = value; }
            get { return _IdL; }
        }

        public DateTime Data {
            set { _Data = value; }
            get { return _Data; }
        }

        public double Valor {
            set { _Valor = value; }
            get { return _Valor; }
        }

        public string Descricao {
            set { _Descricao = value; }
            get { return _Descricao; }
        }

        #endregion

        #region Construtores

        public FormLancamentos() {
            int _IdL = 0;
            DateTime _Data = DateTime.Now;
            double _Valor = 0.0;
            string _Descricao = "";
        }

        public FormLancamentos(int id, string conta, Grupos grupo) : base(id, conta, grupo) {
            int _IdL = IdL;
            DateTime _Data = Data;
            double _Valor = Valor;
            string _Decricao = Descricao;
            Grupos _Grupo = grupo;
        }

        public FormLancamentos(string conta, Grupos grupo) : base(conta, grupo) {
            var _Data = Data;
            double _Valor = Valor;
            string _Decricao = Descricao;
            Grupos _Grupo = grupo;
        }
        #endregion

        #region Metodos

        public static List<FormLancamentos> Consultar() {
            return FormLancamento;
        }
        #endregion
    }
}