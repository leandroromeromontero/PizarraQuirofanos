using System;

namespace PizarraQuirofano.Models.Quirofano
{
    public class Cirugia
    {
        public int Id { get; set; }
        public string Paciente { get; set; }
        public string Identificacion { get; set; }
        public string Cirujano { get; set; }
        public string TipoCirugia { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public string Quirofano { get; set; }
        public string Estado { get; set; } // Ej: Programada, En curso, Finalizada, Cancelada
        public string Observaciones { get; set; }
    }
}