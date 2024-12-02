using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class personagem 
{
    public static int Instancias = 0;
    public string Nome { get; set; }

    public personagem()
    {
        Instancias += 1;
    }
}
