﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiFinalFantaconeFederico.Models
{
    [Table("Doctor")]
    public class Doctor
    {
        [Key]
        public int Doctor_No { get; set; }  

        public int Hospital_Cod { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? Apellido { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? Especialidad { get; set; }    

        public Hospital Hospital { get; set; }
    }
}
