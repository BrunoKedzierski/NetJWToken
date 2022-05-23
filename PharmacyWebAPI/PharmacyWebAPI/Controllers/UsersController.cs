using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PharmacyWebAPI.DAO;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace PharmacyWebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {

        PharmacyDbContext _context;
        IConfiguration _configuration;

        public UsersController(PharmacyDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }



        [HttpPost]
        public IActionResult Login([FromBody] LoginRequestDAO request)
        {
            var user = _context.Users.FirstOrDefault(u => u.Login == request.Login &&  u.Password == request.Password );

            if (user == null)
                return Unauthorized("Wrong credentials");

            var role = user.Role;
            var claims = new Claim[] { 
            new Claim(ClaimTypes.Name,request.Login),
            new Claim(ClaimTypes.Role,role)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWTsecret"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var tokenOpition = new JwtSecurityToken("https://localhost:17801", "https://localhost:17801", claims, expires: DateTime.Now.AddMinutes(5), signingCredentials: creds);
          

            var refreashToken = "";
            using (var randNum = RandomNumberGenerator.Create()) 
            {
                var r = new Byte[1024];
                randNum.GetBytes(r);
                refreashToken = Convert.ToBase64String(r);
            }

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(tokenOpition),
                refreashToken

            });
        }


      

    }
}
