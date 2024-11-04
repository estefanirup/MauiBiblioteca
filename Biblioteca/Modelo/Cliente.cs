using System;

namespace Biblioteca.Modelo;

public class Cliente
{
    public int ClienteId { get; set; }
    public string Nome { get; set; }
    public string DataNascimento { get; set; }
    public string Genero { get; set; }
    public string Telefone { get; set; }

     public override string ToString()
    {
        return $"[{ClienteId}, {Nome}, {DataNascimento}, {Genero}, {Telefone}]";
    }
}
