using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FindABand.Data;
using FindABand.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FindABand.Controllers
{
    public class ConnectedBandController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConnectedBandController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> List()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userAccount = await _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefaultAsync();
            var invites = _context.AcceptedInvites.Where(x => x.RecipientId == userAccount.ProfileId);
            List<Band> bands = new List<Band>();
            foreach (var invite in invites)
            {
                bands.Add(_context.Bands.Where(x => x.BandId == invite.SenderId).FirstOrDefault());
            }
            return View(bands);
        }
    }
}