using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WordAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _datacontext;
        public UserController(DataContext dataContext)
        {
            _datacontext = dataContext;
        }



        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _datacontext.Users.ToListAsync());


        }
        [HttpPost]
        public async Task<ActionResult<List<User>>> PostHero(User a)
        {
            _datacontext.Users.Add(a);
            await _datacontext.SaveChangesAsync();
            return Ok(await _datacontext.Users.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<User>>> ChangeUser(User request)
        {
            User userBeingChanged = await _datacontext.Users.FindAsync(request.Id);
            if (userBeingChanged == null)
                return BadRequest("NO USER");
            userBeingChanged.Name = request.Name;
            await _datacontext.SaveChangesAsync();
            return Ok(userBeingChanged);

        }
        [HttpDelete]
        public async Task<ActionResult<List<User>>> DeleteUser(int id){
            User userBeingDeleted = await _datacontext.Users.FindAsync(id);
            _datacontext.Users.Remove(userBeingDeleted);
            await _datacontext.SaveChangesAsync();  
          return Ok(userBeingDeleted);
        }
    }
}

