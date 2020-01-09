using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EntityProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EntityProject.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext= context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("signin")]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User register)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any( u => u.Email == register.Email))
                {
                    ModelState.AddModelError("Email", "That email has already been registered!");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    register.Password = Hasher.HashPassword(register, register.Password);

                    dbContext.Users.Add(register);
                    dbContext.SaveChanges();
                    HttpContext.Session.SetString("UserEmail", register.Email);
                    return RedirectToAction("Dashboard");
                }
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult LogIn(LoginUser login)
        {
            if(ModelState.IsValid)
            {
                User userInDb = dbContext.Users.FirstOrDefault( u => u.Email == login.LoginEmail);
                if( userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("SignIn");
                }
                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(login, userInDb.Password, login.LoginPassword);
                if(result == 0)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Pasword");
                    return View("SignIn");

                }
                HttpContext.Session.SetString("UserEmail", login.LoginEmail);
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("SignIn");
            }
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            User userInDb = dbContext.Users.FirstOrDefault( u => u.Email == HttpContext.Session.GetString("UserEmail"));
            if(userInDb == null)
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Index");
            }
            return View(userInDb);
        }

        [HttpGet("logout")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

////////////////////////////////    Workout Actions     /////////////////////////////////////////////////////////

        [HttpGet("{muscle_Id}")]
        public IActionResult DispMuscle(int muscle_Id)
        {
            Muscle DispMuscle = dbContext.Muscles.Include( w => w.mTrains).ThenInclude( t => t.tWorkout).FirstOrDefault( w => w.MuscleId == muscle_Id );

            User userInDb = dbContext.Users.FirstOrDefault( u => u.Email == HttpContext.Session.GetString("UserEmail"));

            ViewBag.LogUser = userInDb;

            return View("DispMuscle", DispMuscle);
        }

        [HttpGet("myplan/{workout_id}/{userId}/{status}")]
        public IActionResult AddWorkout(int workout_id, int userId, string status)
        {
            if(HttpContext.Session.GetString("UserEmail") == null)
            {
                return RedirectToAction("LogOut");
            }
            else
            {
                if(status == "add")
                {
                    Plan myPlan = new Plan();
                    myPlan.UserId = userId;
                    myPlan.WorkoutId = workout_id;
                    dbContext.Plans.Add(myPlan);
                    dbContext.SaveChanges();
                }
                if(status == "remove")
                {
                    Plan remove = dbContext.Plans.FirstOrDefault(a=>a.WorkoutId == workout_id && a.UserId == userId);
                    dbContext.Plans.Remove(remove);
                    dbContext.SaveChanges();
                }
            }
            return RedirectToAction("Dashboard");
        }

        [HttpGet("myplan/{userId}")]
        public IActionResult MyPlan(int userId)
        {
            if(HttpContext.Session.GetString("UserEmail") == null)
            {
                return RedirectToAction("LogOut");
            }
            User userInDb = dbContext.Users.FirstOrDefault( u => u.Email == HttpContext.Session.GetString("UserEmail"));
            ViewBag.Compare = userInDb;

            var planstuff = dbContext.Users.Include(a=>a.MyPlan).ThenInclude(b=>b.WorkoutPlan).FirstOrDefault(c=>c.UserId == userId);

            return View(planstuff);
        }
    }
}
