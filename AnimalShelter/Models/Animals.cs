using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AnimalShelter.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Species { get; set; }

        [StringLength(20)]
        public string Breed { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Age Must be Between 0 and 100.")]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public bool SpayedOrNeutered { get; set; }

        [Required]
        public bool AvailableForAdoption { get; set; }
    }
}