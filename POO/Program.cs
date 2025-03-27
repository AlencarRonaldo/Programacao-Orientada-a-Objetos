//LISTAS

//<> generico

//List<string> ListaDeNomes = new List<string>();

// versao atualizada c#
//List<string> ListaDeNomes2 = new();

//ListaDeNomes2.Add("Ronaldo");
//ListaDeNomes2.Add("Joao");


//POO PROGRAMACAO ORIENTADA A OBEJTOS

// 4 PILARES DA POO PROGRAMACAO ORIEMTADA A OBJETOS
// CLASSE seria a definicao (da forma) (seria o adjetivo)
//OBJETO seria uma instancia da classe (seria substantivo)

// clase definicao item da vida real representado em codigo
// atributos caracteristicas - metodos e acoes

// Objeto -  instancia de uma classe

//ENCAPSULAMENTO - Esconder comportamento e atributos
//public - esse atributo ou metodo pode ser acessadi por qualquer pessoa
//private - 
//protected/internal - esse atributo, metodo ou claase so pode ser acessado por ele mesmo ou pela classe pai
//VANTANGENS
//1 rsconder metodos/atributos/claase
//2 defino regras para altera;ao
//get - metodo para um atributo privado
//set metodo para alterar um atributo






using POO;

//Carro carro1 = new Carro();

//carro1.modelo = "HB20";
//carro1.marca = "Hyundai";
//carro1.anoFabricacao = 2024;

//carro1.andar();
//carro1.Parar();

//// crie mais 2 carros

//Carro carro2 = new Carro();
//carro2.modelo = "118I";
//carro2.marca = "Bmw";
//carro2.anoFabricacao = 2022;

//carro2.andar();
//carro2.Parar();

//Carro carro3 = new Carro();
//carro2.modelo = "Gol";
//carro2.marca = "VolksWagen";
//carro2.anoFabricacao = 2025;

//carro2.andar();
//carro2.Parar();

//crie class livro

livro livro1 = new livro();

livro1.Titulo = "Cavaleiro preso na armadura";
livro1.Autor = "RObert Fisher";
livro1.Paginas = 100;

livro livro2 = new livro()
{
    Autor = "Robert Martin",
    Titulo = "Clean Code",
    Paginas = 363
};

Console.WriteLine(livro1.Autor);
Console.WriteLine(livro1.Titulo);
Console.WriteLine(livro1.Paginas);

//classe aluno

Aluno aluno1 = new Aluno()
{
    nome = "Ronaldo Carvalho",
    idade = 36,
    notaFinal = 7
};
Console.WriteLine(aluno1.nome);
Console.WriteLine(aluno1.idade);
Console.WriteLine(aluno1.notaFinal);

Aluno aluno2 = new Aluno()
{
    nome = "Rones Carvalho",
    idade = 34,
    notaFinal = 6
};
Console.WriteLine(aluno2.nome);
Console.WriteLine(aluno2.idade);
Console.WriteLine(aluno2.notaFinal);

Produto produto = new Produto()
{
    nome = "Camiseta",
    preco = 25.90,
    quantidadeEmEstoque = 15
};
Console.WriteLine(produto.CalcularTotal());















































































