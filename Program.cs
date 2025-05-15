void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1} a palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    bool palavraEncontrada = false;

    foreach (string str in arrayDePalavras)
    {
        if (str.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {str}");
            palavraEncontrada = true;
            break;
        }
    }

    if (!palavraEncontrada)
    {
        Console.WriteLine($"Palavra {busca} não encontrada");
    }
}

TestaBuscarPalavra();
