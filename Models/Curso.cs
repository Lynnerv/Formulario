using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Formulario.Models
{
    public class Curso
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Display(Name = "Categoría")]
        [Required(ErrorMessage = "La categoría es obligatoria.")]
        public CategoriaCurso Categoria { get; set; }

        [Display(Name = "Créditos")]
        [Range(1, 5, ErrorMessage = "Los créditos deben estar entre 1 y 5.")]
        public int Creditos { get; set; }

        [Display(Name = "Modalidad")]
        [Required(ErrorMessage = "La modalidad es obligatoria.")]
        public ModalidadCurso Modalidad { get; set; }

        [Display(Name = "Material del Curso")]
        public TipoMaterial Material { get; set; }

        [Display(Name = "Hora")]
        [Required(ErrorMessage = "La hora es obligatoria.")]
        [DataType(DataType.Time)]
        public DateTime Hora { get; set; }
    }

    public enum CategoriaCurso
    {
        Obligatoria,
        NoObligatoria,
        Electivo
    }

    public enum ModalidadCurso
    {
        Remoto,
        Presencial,
        Hibrido
    }

    public enum TipoMaterial
    {
        Video,
        Libro
    }
}