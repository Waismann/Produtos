using System.Globalization;

namespace EtiquetaProdutos.Entities
{
    class ProdutoImportado : Produto 
    {
        public double TaxaImportacao { get; set; }

        public ProdutoImportado() 
        {
        }

        public ProdutoImportado(string nome, double preco, double taxaImportacao)
            : base (nome,preco)
        {
            TaxaImportacao = taxaImportacao;
        }

        public double PrecoTotal ()
        {
            return Preco + TaxaImportacao;
        }

        public override string PrecoEtiqueta()
        {
            return Nome
                + " $ "
                + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture)
                + " (Taxa da importação: $ "
                + TaxaImportacao.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
