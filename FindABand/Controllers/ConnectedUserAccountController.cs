using FindABand.Data;
using FindABand.Models;
using FindABand.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FindABand.Controllers
{
    public class ConnectedUserAccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConnectedUserAccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> List()
        {
            var model = new ConnectedUserViewModel();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userAccount = await _context.UserAccounts.Where(x => x.UserId == userId).FirstOrDefaultAsync();
            model.AcceptedInvites = _context.AcceptedInvites.Where(x => x.UserRecipientId == userAccount.ProfileId || x.UserSenderId == userAccount.ProfileId).ToList();

            //List<Band> userBands = new List<Band>();
            model.UserBands = _context.Bands.Where(x => x.UserId == userId).ToList();

            foreach (var band in model.UserBands)
            {
                if (band != null)
                {
                    var invite = await _context.AcceptedInvites.Where(x => x.BandRecipientId == band.BandId || x.BandSenderId == band.BandId).ToListAsync();
                    foreach (var i in invite)
                    {
                        model.AcceptedInvites.Add(i);
                    }
                }
            }

            List<UserAccount> UserAccounts = new List<UserAccount>();


            foreach (var invite in model.AcceptedInvites)
            {
                if (invite != null)
                {
                    var Account = new UserAccount();
                    if (invite.UserSenderId == null)
                    {
                        Account = await _context.UserAccounts.Where(x => x.ProfileId == invite.UserRecipientId).FirstOrDefaultAsync();
                    }
                    else
                    {
                        Account = await _context.UserAccounts.Where(x => x.ProfileId == invite.UserSenderId).FirstOrDefaultAsync();
                    }
                    UserAccounts.Add(Account);
                }
            }

            model.ConnectedAccounts = UserAccounts;
            return View(model);
        }
    }
}