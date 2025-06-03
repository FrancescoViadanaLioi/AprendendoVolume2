using System;

class Validacao
{
    public int QntdElem(int N)
    {
        while (true)
        {
            Console.Write("Digite quantos elementos a matriz vai ter: ");
            if (int.TryParse(Console.ReadLine(), out N) || N > 0) return N;
            Limpar();
        }
    }

    static void Limpar()
    {
        Console.WriteLine("Valor inválido, digite novamente.\n(Pressione qualquer tecla para continuar)");
        Console.ReadKey();
        Console.Clear();
    }
}