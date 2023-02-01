namespace tabuleiro
{
    public class Tabuleiro
    {
        public int linha { get; set; }
        public int coluna { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
            this.pecas= new Peca[linha,coluna];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        
        
        
    }
}