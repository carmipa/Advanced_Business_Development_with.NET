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
                produtos[i].Codigo = int.Parse(Interaction.InputBox($"Código do produto #{i + 1}:", "Entrada"));
                produtos[i].NomeProduto = Interaction.InputBox($"Nome do produto #{i + 1}:", "Entrada");
                produtos[i].Quantidade = int.Parse(Interaction.InputBox($"Quantidade #{i + 1}:", "Entrada"));
                produtos[i].ValorUnitario = double.Parse(Interaction.InputBox($"Valor unitário #{i + 1} (R$):", "Entrada"), CultureInfo.InvariantCulture);
                produtos[i].Desconto = double.Parse(Interaction.InputBox($"Desconto #{i + 1} (%):", "Entrada"), CultureInfo.InvariantCulture);
            }

            // Construindo relatório
            var relatório = new System.Text.StringBuilder();
            relatório.AppendLine("====== Relatório de Produtos ======\n");
            foreach (var p in produtos)
            {
                relatório.AppendLine($"Produto: {p.NomeProduto}");
                relatório.AppendLine($"Quantidade: {p.Quantidade}");
                relatório.AppendLine($"Valor Unitário: {p.ValorUnitario:F2} R$");
                relatório.AppendLine($"Desconto: {p.Desconto:F2}%");
                relatório.AppendLine($"Total sem desconto: {p.ValorSemDesconto():F2} R$");
                relatório.AppendLine($"Total com desconto: {p.ValorComDesconto():F2} R$\n");
                relatório.AppendLine("---------------------------------\n");
            }

            MessageBox.Show(relatório.ToString(), "Relatório Final", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();
        }

    }
}
