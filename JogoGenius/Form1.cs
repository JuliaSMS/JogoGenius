namespace JogoGenius
{
    public partial class Form1 : Form
    {
        int sequenciaSelecionada = -1;
        int sequenciaAtual = 0;
        int aux = 0;
        List<Button> sequencia;
        Color corPadrao;
        Color corPiscando;
        bool piscando = false;
        int nivel = 0;

        string corVerdePadrao = "#004700";
        string corAmareloPadrao = "#F0B200";
        string corVermelhoPadrao = "#A80A00";
        string corAzulPadrao = "#06006B";

        string corVerdePiscando = "#008A00";
        string corAmareloPiscando = "#FFD047";
        string corVermelhoPiscando = "#F50E00";
        string corAzulPiscando = "#0C00D6";
        public Form1()
        {
            InitializeComponent();

            btnVerde.BackColor = ColorTranslator.FromHtml(corVerdePadrao);
            btnAmarelo.BackColor = ColorTranslator.FromHtml(corAmareloPadrao);
            btnVermelho.BackColor = ColorTranslator.FromHtml(corVermelhoPadrao);
            btnAzul.BackColor = ColorTranslator.FromHtml(corAzulPadrao);

            btnVerde.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corVerdePadrao);
            btnAmarelo.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corAmareloPadrao);
            btnVermelho.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corVermelhoPadrao);
            btnAzul.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corAzulPadrao);

            btnVerde.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corVerdePiscando);
            btnAmarelo.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corAmareloPiscando);
            btnVermelho.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corVermelhoPiscando);
            btnAzul.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corAzulPiscando);

            btnVerde.Cursor = Cursors.Hand;
            btnAmarelo.Cursor = Cursors.Hand;
            btnVermelho.Cursor = Cursors.Hand;
            btnAzul.Cursor = Cursors.Hand;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            sequenciaSelecionada = -1;
            sequencia = new List<Button>();
            btnIniciar.Enabled = false;

            nivel++;
            lbnivel.Text = nivel.ToString();

            GerarSequencia();
            Piscando();
            HabilitaDesabilitaBotao(true);
        }

        private void GerarSequencia()
        {
            Random random = new Random();
            int num = random.Next(0, 4);

            Button bt = null;

            switch (num)
            {
                case 0:
                    bt = btnVerde;
                    break;
                case 1:
                    bt = btnAmarelo;
                    break;
                case 2:
                    bt = btnVermelho;
                    break;
                case 3:
                    bt = btnAzul;
                    break;
            }
            sequencia.Add(bt);
        }

        private void Piscando()
        {
            aux = 0;

            for (int i = 0; i < sequencia.Count; i++)
            {
                sequenciaAtual = i;

                corPadrao = sequencia[i].BackColor;

                if (sequencia[i] == btnVerde)
                    corPiscando = ColorTranslator.FromHtml(corVerdePiscando);
                else if (sequencia[i] == btnAmarelo)
                    corPiscando = ColorTranslator.FromHtml(corAmareloPiscando);
                else if (sequencia[i] == btnVermelho)
                    corPiscando = ColorTranslator.FromHtml(corVermelhoPiscando);
                else if (sequencia[i] == btnAzul)
                    corPiscando = ColorTranslator.FromHtml(corAzulPiscando);

                timer1.Start();

                while (aux == i)
                {
                    Application.DoEvents();
                }
            }
        }

        private void HabilitaDesabilitaBotao(bool Habilita)
        {
            btnVerde.Enabled = Habilita;
            btnAmarelo.Enabled = Habilita;
            btnVermelho.Enabled = Habilita;
            btnAzul.Enabled = Habilita;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!piscando)
            {
                sequencia[sequenciaAtual].BackColor = corPiscando;
                piscando = true;
            }
            else
            {
                sequencia[sequenciaAtual].BackColor = corPadrao;
                piscando = false;
                aux++;
                timer1.Stop();
            }
        }
        private void bt_click(object sender, EventArgs e)
        {
            sequenciaSelecionada++;

            if (sequencia[sequenciaSelecionada] == (Button)sender)
            {
                if (sequencia.Count - 1 == sequenciaSelecionada) 
                {
                    nivel++;
                    lbnivel.Text = nivel.ToString();
                    sequenciaSelecionada = -1;
                    HabilitaDesabilitaBotao(false);
                    GerarSequencia();
                    Thread.Sleep(500);
                    Piscando();
                    HabilitaDesabilitaBotao(true);
                }
            }
            else
            {
                btnIniciar.Enabled = true;
                HabilitaDesabilitaBotao(false);
                nivel = 0;
                lbnivel.Text = "0";
                MessageBox.Show("Sequencia incorreta! Fim de Jogo!");
            }
        }
    }
}
