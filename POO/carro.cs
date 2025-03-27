using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Carro
    {
        //ATRIBUTOS
        public string marca;
        private string _modelo;
        public int anoFabricacao;

        //METODOS
        public void AlterarModelo(string mod)
        
        {
            if((mod == "fietsa" || mod == "HB220")
            {
                _modelo = mod;
            }
            else
            {
                Console.WriteLine("Alteracao Invalida");
            }
        }

        public void Parar()
        {
            Console.WriteLine("Carro esta andando");
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine($"MArca: {marca}, Modelo: {modelo}, Ano de Fabricacao: {anoFabricacao}");
        }
    }
}
