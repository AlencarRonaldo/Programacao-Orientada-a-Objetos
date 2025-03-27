using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace POO
{
    class Aluno
    {
        public string nome;
        public int idade;
        public double notaFinal;

     public void MostrarInformacoes()
        {
            Console.WriteLine($"Nome: {nome}, Idade: {idade}, Nota Final: {notaFinal}");
        }
    }
}