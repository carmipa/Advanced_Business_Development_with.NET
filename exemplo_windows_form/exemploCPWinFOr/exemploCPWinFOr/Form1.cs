using Microsoft.VisualBasic;
using System.Globalization;

namespace exemploCPWinFOr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Produtos[] produtos = new Produtos[2];

            for (int i = 0; i < 2; i++)
            {
                produtos[i] = new Produtos();
                produtos[i].Codigo = int.Parse(Interaction.InputBox($"C�digo do produto #{i + 1}:", "Entrada"));
                produtos[i].NomeProduto = Interaction.InputBox($"Nome do produto #{i + 1}:", "Entrada");
                produtos[i].Quantidade = int.Parse(Interaction.InputBox($"Quantidade #{i + 1}:", "Entrada"));
                produtos[i].ValorUnitario = double.Parse(Interaction.InputBox($"Valor unit�rio #{i + 1} (R$):", "Entrada"), CultureInfo.InvariantCulture);
                produtos[i].Desconto = double.Parse(Interaction.InputBox($"Desconto #{i + 1} (%):", "Entrada"), CultureInfo.InvariantCulture);
            }

            // Construindo relat�rio
            var relat�rio = new System.Text.StringBuilder();
            relat�rio.AppendLine("====== Relat�rio de Produtos ======\n");
            foreach (var p in produtos)
            {
                relat�rio.AppendLine($"Produto: {p.NomeProduto}");
                relat�rio.AppendLine($"Quantidade: {p.Quantidade}");
                relat�rio.AppendLine($"Valor Unit�rio: {p.ValorUnitario:F2} R$");
                relat�rio.AppendLine($"Desconto: {p.Desconto:F2}%");
                relat�rio.AppendLine($"Total sem desconto: {p.ValorSemDesconto():F2} R$");
                relat�rio.AppendLine($"Total com desconto: {p.ValorComDesconto():F2} R$\n");
                relat�rio.AppendLine("---------------------------------\n");
            }

            MessageBox.Show(relat�rio.ToString(), "Relat�rio Final", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();
        }

    }
}
