using Microsoft.CodeAnalysis.Elfie.Extensions;

namespace WebApiFinal.Models
{
    public class Produtos : Base
    {

        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }


        //tipos de dados
        string nome = "etec";//tipo de referencia
        char letra = 'e';

        int valor = 10; //numeros inteiros
        long valor1 = 10L; //numeros inteiros
        byte valorb = 127; //numeros inteiros

        float valorF = 10.5F; //numeros reais
        double valorD = 10.5; //numeros reais



    }
}
