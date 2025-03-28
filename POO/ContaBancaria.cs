using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace POO
{
     class ContaBancaria
    {
        private double _salario;
       
        public void Despositar(double valor)
        {

            _saldo = _saldo + valor;
        }

        public void Sacar(double valor)
        {
            _saldo -= valor;
        }
        public double VerSaldo()
        {
            return _saldo;
        }
    
    }
}
