using System;

class Lampada
{
    public int Codigo { get; set; }
    public int Potencia { get; set; }
    public bool Acesa { get; set; }

    public Lampada(int potencia)
    {
        Codigo = 0;
        Potencia = potencia;
        Acesa = false;
    }
}