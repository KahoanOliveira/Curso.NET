using System;


/*
    ****************************************Construtor****************************************
    
    Um construtor é um método especial usado para inicializar objetos.
        - É chamado quando um objeto de uma classe é criado usando a palavra-chave *new*.
        - Pode ser usado para definir valores iniciais para os atributos de um objeto.

    Na linguagem C# por padrão, toda classe tem um construtor padrão sem nenhum parâmetro
        - Para tipos de Referência (que são strings) ele atribui o valor *null*.
        - Para tipos de Valor (que são int's) ele atribui o valor *0*.

    O nome do construtor deve corresponder ao nome da classe e não tem um tipo de retorno.
    O construtor é chamado quando o objeto é criado.
    Todas as classes possuem um construtor publico padrão sem parâmetros.
    Quando uma classe é instânciada seu construtor é chamado.

    Podemos ter mais de um construtor com parâmetros distintos, e isso chamamos de Sobrecarga.
    Assim como outros métodos, os construtores podem ser sobrecarregados usando diferentes
    números de parâmetros.
    Se você criar dois métodos em seu código com o mesmo nome e com parâmetros diferentes
    estará usando o recurso da Sobrecarga.

    Quando se faz um construtor é sempre bom criar um vazio para imitar o construtor padrão,
    assim caso não seja passado nenhum parâmetro ele irá atribuir os valores padrões.

    ********Exemplo de um construtor********
    
    Class Pessoa  ----------> Uma classe qualquer.
    {
        string Nome;
        string Genero;
        int    Idade;

        public Pessoa()  ----------> Um método que será nosso construtor inicializando os campos(Fields) do objeto.
        {
            nome   = "Kahoan";
            Genero = "Masculino";
            Idade  = 21;
        }
    }

    ********O que é this.?********
    
    O this. é usado em um construtor e representa uma instância da classe na qual o construtor
    está alocado
*/


namespace Aula_POO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de usar um construtor sem parâmetro, onde você deve atribuir os valores após a criação do objeto.
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Kahoan";
            pessoa1.Genero = "Masculino";
            pessoa1.Idade = 21;
            pessoa1.Identificar();


            // Exemplo de usar um construtor onde é passado os parâmetros que serão atribuidos no momento da criação do objeto.
            Pessoa pessoa2 = new Pessoa("Raquel", "Feminino", 20);
            pessoa2.Identificar();
        }
    }
}
