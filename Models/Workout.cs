using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityProject.Models
{
    public class Workout
    {
        [Key]
        public int WorkoutId {get; set;}

        [Required]
        public string WorkoutName {get; set;}

        [Required]
        public string Description {get; set;}

        public string Animation {get; set;}

        // Nav Properties //
        public int MuscleId {get; set;}
        public Muscle wMuscle {get;set;}
        
        public List<Train> wTrains {get;set;}
        public List<Plan> addedWorkouts {get;set;}


        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}  