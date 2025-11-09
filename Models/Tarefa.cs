using System;
using System.ComponentModel.DataAnnotations;

namespace CamadaNetApiDesafio.Models
{
    public enum StatusTarefa
    {
        Pendente,
        Concluida,
        Cancelada
    }

    public class Tarefa
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Titulo { get; set; }
        [MaxLength(1000)]
        public string Descricao { get; set; }
        public DateTime Data { get; set; } = DateTime.UtcNow;
        [Required]
        public StatusTarefa Status { get; set; } = StatusTarefa.Pendente;
    }
}
