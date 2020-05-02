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
        static int MaxId = 0;

        protected int _IdL;
        protected int _Dia;
        protected int _Mes;
        protected int _Ano;
        protected int _Valor;
        protected string _Descricao;

        #region Acesso a Dados

        public int IdL {
            set { _IdL = value; }
            get { return _IdL; }
        }


        #endregion

        #region Construtores
        #endregion

        #region Metodos
        #endregion



    }
}
