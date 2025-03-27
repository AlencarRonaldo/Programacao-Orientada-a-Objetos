using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class livro
    {
        public string Titulo;
        public string Autor;
        public int Paginas;

        //METODOS
        public void Ler()
        {
            Console.WriteLine("Lendo Livro");
        }

        public void Parar()
        {
            Console.WriteLine("Efetuado leitura ate a pagina");
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine($"Autor: {Autor}, Titulo: {Titulo}, Paginas: {Paginas}");
        }
    }
}
