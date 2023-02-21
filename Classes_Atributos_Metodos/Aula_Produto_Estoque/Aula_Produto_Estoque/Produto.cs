
using System.Globalization;

namespace Aula_Produto_Estoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Metodos utilizado para verficar o valor em estoque
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        // Metodo usado para adicionar produtos na quantidade do estoque
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        // Metodo usado para remover produtos na quantidade do estoque
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        // Subscrevendo o metodo ToString para ser impresso o objeto na chamada de impressão
        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " + Quantidade + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }   
}
