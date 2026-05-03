using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendoCita.Domain.Entities;

public class Profesional
{
    public int ProfesionalId { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public ICollection<Turno> Turnos { get; set; } = new List<Turno>();

}
