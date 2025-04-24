# 🖥️ CP1 – Sistema de Controle de Produtos em C#

# PAULO ANDRÉ CARMINATI - RM557881

**🎯 Objetivo:**  
Desenvolver um programa em C# que simule um sistema de controle de produtos, permitindo cadastrar dois produtos, calcular valores e aplicar descontos conforme regras abaixo.

---

## 📜 Regras do Programa

1. **Entrada de Dados**  
   - Nome do produto (ex: `"Notebook"`)  
   - Preço unitário (ex: `2500.00`)  
   - Quantidade em estoque (ex: `3`)  
   - Desconto percentual (ex: `10` para 10%)

2. **Cálculos**  
   - **Custo Total** = Preço Unitário * Quantidade  
   - Se **Custo Total > R$ 5000**, aplicar desconto:  
     ```csharp
     CustoFinal = CustoTotal - (CustoTotal * (Desconto / 100))
     ```

3. **Saída**  
   - Exibir **Custo Total** e **Custo Final** de cada produto.  
   - Indicar qual produto teve o **maior custo final**.

---

## 🏗️ Estrutura da Classe `Produto`

```csharp
public class Produto
{
    // Atributos privados
    private string Nome;
    private decimal PrecoUnitario;
    private int Quantidade;
    private decimal Desconto;

    // Construtor
    public Produto(string nome, decimal precoUnitario, int quantidade, decimal desconto)
    {
        Nome = nome;
        PrecoUnitario = precoUnitario;
        Quantidade = quantidade;
        Desconto = desconto;
    }

    // Método para calcular custo total
    public decimal CalcularCustoTotal()
    {
        return PrecoUnitario * Quantidade;
    }

    // Método para calcular custo final com desconto
    public decimal CalcularCustoFinal()
    {
        decimal total = CalcularCustoTotal();
        if (total > 5000)
            return total - (total * (Desconto / 100));
        return total;
    }

    // Método para exibir detalhes do produto
    public void ExibirDetalhes()
    {
        decimal total = CalcularCustoTotal();
        decimal final = CalcularCustoFinal();
        Console.WriteLine($"🛒 {Nome}");
        Console.WriteLine($"   Custo Total: R$ {total:F2}");
        Console.WriteLine($"   Custo Final: R$ {final:F2}");
    }
}
