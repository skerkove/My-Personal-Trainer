using System.ComponentModel.DataAnnotations;

namespace EntityProject.Models
{
    public class Train
    {
        [Key]
        public int TrainId{get; set;}
        public int MuscleId{get; set;}
        public int WorkoutId{get; set;}
        public Muscle tMuscle {get; set;}
        public Workout tWorkout {get; set;}

    }
}