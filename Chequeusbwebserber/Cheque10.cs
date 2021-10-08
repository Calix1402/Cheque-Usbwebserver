using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chequeusbwebserber
{
    class Cheque
    {
        public int _Chequeid { get; set; }
        public string _Banco { get; set;  }
        public string _Usuario { get; set; }
        public string _Dinero { get; set; }
        public string _Firma { get; set; }

        public Cheque ()
        {

        }

        public Cheque(int Cheque, string Banco, string Usuario, string Dinero , string Firma)
        {
            _Chequeid = Cheque;
            _Banco = Banco;
            _Usuario = Usuario;
            _Dinero = Dinero;
            _Firma = Firma; 
        }

       

        public string getchequeInfo()
        {
            return " ID " + _Chequeid + " 1 " + _Banco + " Agricola " + _Usuario + " Alexis Calix"
               + _Dinero + " 2,000 " + _Firma + " A...M..";
        }

    }
}
