﻿using ScreenSound.Menus;
using ScreenSound.Modelos;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Obrigado por utilizar nosso programa");
    }
}