using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendoCita.Domain.Entities;

public class Cliente
{
    public int ClienteId { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public string Mail { get; set; } = string.Empty;

    public ICollection<Turno> Turnos { get; set; } = new List<Turno>();

    //public Cliente() { }

    //public Cliente(int id, string nombre)
    //{
    //    Id = id;
    //    Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
    //}

    //public override string ToString() => $"{Nombre} ({Id})";
}
