using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendoCita.Domain.Entities;

public class Turno
{
    public int TurnoId { get; set; }
    public DateTime FechaHora { get; set; }
    public string Estado { get; set; } = string.Empty;
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; } = null!;
    public int ProfesionalId { get; set; }
    public Profesional Profesional { get; set; } = null!;

    //public Turno() { }
    //public Turno(int id, DateTime fechaHora, int clienteId)
    //{
    //    Id = id;
    //    FechaHora = fechaHora;
    //    ClienteId = clienteId;
    //}
}

