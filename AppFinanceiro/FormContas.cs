using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinanceiro {
    class FormContas {

        public enum Grupos { receita, despesa}

        protected Grupos _Grupo;
        protected int _Id;
        protected string _Conta;

        #region Codigos de Acesso

        public int Id {
            set { _Id = value; }
            get { return _Id; }
        }

        public Grupos Grupo  {
            set { _Grupo = value;}
            get { return _Grupo; }
        }

        public string Conta {
            set { _Conta = value; }
            get { return _Conta; }
        }

        #endregion

        #region Construtores

        public FormContas() {
            _Id = 0;
            _Conta = "";
            _Grupo = Grupos.despesa;
        }

        public FormContas(string conta, Grupos grupo) {
            _Id = 0;
            _Conta = conta;
            _Grupo = grupo;
        }

        public FormContas(int id, string conta, Grupos grupo) {
            _Id = id;
            _Conta = conta;
            _Grupo = grupo;
        }
        #endregion
    }
}
