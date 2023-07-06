using System;
using System.Collections.Generic;
using System.Text;


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
    class Pessoa
    {
        // Field
        public string Nome;
        public int Idade;
        public string Genero;

        // Constructor padrão, onde se não for declarado os valores após a criação do objeto irá atribuir os valores padrões.
        public Pessoa()
        {
        }

        // Constructor com parâmetros que devem ser passados no momento da criação do objeto.
        public Pessoa(string Nome, string Genero, int Idade) 
        {
            this.Nome   = Nome;
            this.Genero = Genero;
            this.Idade  = Idade; 
        }

        // Method
        public void Identificar()
        {
            Console.WriteLine($"Olá sou o {Nome}, minha idade é de {Idade} anos e sou do sexo {Genero}.");
        }
    }
}
