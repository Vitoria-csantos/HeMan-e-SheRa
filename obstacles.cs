
using UnityEngine;
using System;

public class obstacles
{
    public static int Instancias = 0;


    GameObject platform;

    public string Nome { get; set; }
    public double Valor { get; set; }
    GameObject bone;
    GameObject sword01;
    GameObject sword02;
    GameObject box;
    GameObject platform01;

    public obstacles()
    {
        Instancias += 1;
    }
    public obstacles(string nome, GameObject tipo)
    {
        Instancias += 1;
        this.Nome = nome;
        this.bone = tipo;
        this.sword01 = tipo;

    }
    public obstacles(string nome, double vlr)
    {
        Instancias += 1;
        this.Nome = nome;
        this.Valor = vlr;
        
    }
}
