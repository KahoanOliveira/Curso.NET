using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao
{
    internal class Exercicio1
    {
        public string texto { get; private set; }
        public string produto1 { get; private set; }
        public string produto2 { get; private set; }
        public byte idade { get; private set; }
        public int codigo { get; private set; }
        public char genero { get; private set; }
        public double preco1 { get; private set; }
        public double preco2 { get; private set; }
        public double medida { get; private set; }

        public Exercicio1()
        {
                
        }

        public Exercicio1(string produto1, string produto2, byte idade, int codigo, char genero, double preco1, double preco2, double medida)
        {
            this.produto1 = produto1;
            this.produto2 = produto2;
            this.idade = idade;
            this.codigo = codigo;
            this.genero = genero;
            this.preco1 = preco1;
            this.preco2 = preco2;
            this.medida = medida;

            string valorInvariant = medida.ToString(CultureInfo.InvariantCulture);
            this.texto = $"Produtos: \n " +
                $"{produto1}, cujo preço é R$ {preco1:F2} \n " +
                $"{produto2}, cujo preço é R$ {preco2} \n" +
                $"\n" +
                $"Registro: {idade} anos de idade, código {codigo} e gênero: {genero} \n " +
                $"\n" +
                $"Medida com casas decimais: {medida:F8} \n" +
                $"Arredondando (três casas decimais): {medida:F3} \n" +
                $"Separador decimal invariant culture: {valorInvariant}"; ;
        }

        
    }
}
