using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityProject.Models
{
    public class Muscle
    {
        [Key]
        public int MuscleId {get; set;}

        [Required]
        public string MuscleName {get; set;}

        // nav properties
        public List<Train> mTrains {get;set;}
        public List<Workout> mWorkouts {get;set;}

        

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}