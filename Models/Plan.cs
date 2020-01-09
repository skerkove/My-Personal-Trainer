using System.ComponentModel.DataAnnotations;

namespace EntityProject.Models
{
    public class Plan
    {
        [Key]
        public int PlanId {get;set;}
        public int UserId {get;set;}
        public int WorkoutId {get;set;}
        public User Athlete {get;set;}
        public Workout WorkoutPlan {get;set;}
    }
}