using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendoCita.Domain.Entities;
public class AgendaProfesional
{
    public int AgendaProfesionalId { get; set; }
    public DayOfWeek DiaSemana { get; set; }
    public TimeSpan HoraInicio { get; set; }
    public TimeSpan HoraFin { get; set; }
    public int ProfesionalId { get; set; }
    public Profesional Profesional { get; set; } = null!;
}
