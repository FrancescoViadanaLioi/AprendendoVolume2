using System;

public class Validacao
{
    public int QntdElem()
    {
        int N;
        while (true)
        {
            Console.Write("Digite quantos elementos a matriz vai ter: ");
            if (int.TryParse(Console.ReadLine(), out N) && N > 0) return N;
            Limpar();
        }
    }
    public int[] Loop(int N)
    {
        int[] vet = new int[N];

        for (int i = 0; i < N; i++)
        {
            while (true)
            {
                Console.Write($"DIgite o elemento {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out vet[i])) break;
                Limpar();
            }
        }
        return vet;
    }
    public void MostrarNumeros(int[] vet)
    {
        Console.WriteLine("Números negativos encontrados:");
        bool encontrou = false;

        foreach (int num in vet)
        {
            if (num < 0)
            {
                Console.WriteLine(num);
                encontrou = true;
            }
        }
        if (!encontrou)
        {
            Console.WriteLine("Nenhum número foi encontrado.");
        }
    }
    private void Limpar()
    {
        Console.WriteLine("Valor inválido, digite novamente.\n(Pressione qualquer tecla para continuar)");
        Console.ReadKey();
        Console.Clear();
    }
}