using System;
using System.Collections.Generic;
using System.Text;

/*
    **************************************************CLASSES E OBJETOS**************************************************
 
    Uma classe é um modelo ou template para criar objetos e contém atributos e comportamentos que definem os objetos.

    ------------->OS OBJETOS NÃO EXISTEM SEM UMA CLASSE<-------------
    
    ********Membros da classe********
    
    // Fields
    // Properties
    // Constructor
    // Methods
    
    ********O que é um objeto?********
    Um Objeto é a instância de uma classe criado em tempo de execução usando a palavra *new*. Podemos criar diversos objetos 
    a partir de uma classe. Pode-se criar diversos objetos, vai depender apenas da quantidade de memória que estará sendo 
    usada, já qque os objetos são armazenados na memória.
*/


namespace Aula_POO1
{
    class Pessoa
    {
        // Field
        public string Nome;
        public int Idade;
        public string Genero; 

        // Method
        public void Identificar()
        {
            Console.WriteLine($"Olá sou o {Nome}, minha idade é de {Idade} anos e sou do sexo {Genero}.");
        }
    }
}







