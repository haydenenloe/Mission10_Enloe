using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Mission10_Enloe.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private readonly BowlingLeagueContext _context;

        public EFBowlingRepository(BowlingLeagueContext context)
        {
            _context = context;
        }

        public IEnumerable<BowlerDTO> GetBowlerDTOs()
        {
            var bowlersWithTeams = _context.Bowlers
                .Include(b => b.Team)
                .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks") // Filter by team name
                .Select(b => new BowlerDTO
                {
                    BowlerId = b.BowlerId,
                    BowlerName = $"{b.BowlerFirstName} {(b.BowlerMiddleInit ?? "").Trim()} {b.BowlerLastName}".Trim(),
                    TeamName = b.Team != null ? b.Team.TeamName : "No Team",
                    BowlerAddress = b.BowlerAddress,
                    BowlerCity = b.BowlerCity,
                    BowlerState = b.BowlerState,
                    BowlerZip = b.BowlerZip,
                    BowlerPhoneNumber = b.BowlerPhoneNumber
                })
                .ToList();

            return bowlersWithTeams;
        }
    }
}


