﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Galaxy.ServicesRESTNet.EF.Entities
{
    [Table("Alumno", Schema = "Entrenamiento")]
    public partial class Alumno
    {
        public int AlumnoId { get; set; }
        [StringLength(250)]
        public string Nombre { get; set; }
        [StringLength(250)]
        public string ApellidoPaterno { get; set; }
        [StringLength(250)]
        public string ApellidoMaterno { get; set; }
        public int? Edad { get; set; }
    }
}