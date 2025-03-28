﻿string frase;

Console.WriteLine("Escreva uma frase como se ela fosse dita pelo Cebolinha, da Turma da Mônica");
Console.WriteLine();
Console.WriteLine("Exemplo: Voce merece aprausos, so que na cara ");
frase = Console.ReadLine();



frase = frase
        .Replace("r", "l")
        .Replace("R", "L");

Console.WriteLine(frase);