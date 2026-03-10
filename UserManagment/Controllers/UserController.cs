using Microsoft.AspNetCore.Mvc;
using UserManagment.Model;

namespace UserManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {



        //private readonly IUserService _service;

        // here our code 

        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // what is are http method
        // 1.get method===> when we want to get list of user
        //2 post--- create user
        //3.Delete-- delete user
        //4 put- update the user
        //5 patch- update the user

        // what is the difference between put and patch



        //GET: api/User/GetAll

        // this method fetches all the records from users table

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var users = _context.Users.ToList();
            if (users == null)
            {
                return NotFound(); //status=400
            }
            return Ok(users);  //status=200
        }
        //ctrl+k+d
        //not found
        // bad request
        // return ok 200





        // this method is fetch based on the id



        //

        //api/User/1/GetbyId

        ////api/User/username:ram/password:123/GetbyId

        [HttpGet("{id}/GetById")]

        public IActionResult GetById(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        //Post : api/User/Add

        [HttpPost("Add")]

        public IActionResult Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok(user);
        }


    }
}
