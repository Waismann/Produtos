using System.Globalization;

namespace EtiquetaProdutos.Entities
{
    class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao)
            : base (nome,preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string PrecoEtiqueta()
        {
            return Nome
                + " (Usado) $ "
                + Preco
                + " (Data da fabricação do produto: "
                + DataFabricacao
                + ")";
        }
    }


}
