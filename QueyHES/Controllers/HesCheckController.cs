using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QueyHES.Models;
using QueyHES.Service;

namespace QueyHES.Controllers
{
    public class HesCheckController : Controller
    {
        private readonly HealthMinistryService _healthMinistryService;

        public HesCheckController(HealthMinistryService healthMinistryService)
        {
            _healthMinistryService = healthMinistryService;
        }

        public async Task<IActionResult> CheckHesCodes()
        {
            var hesCodesToCheck = new List<HesCodeCheckRequest>
            {
                new HesCodeCheckRequest { Hes = "G1B5-6449-15" },
                new HesCodeCheckRequest { Hes = "G5B2-3442-88" }
            };

            var results = await _healthMinistryService.CheckHesCodesAsync(hesCodesToCheck);

            var riskyCodes = results.Where(r => r.Status == "risky").ToList();
            var risklessCodes = results.Where(r => r.Status == "riskless").ToList();

            ViewBag.RiskyCodes = riskyCodes;
            ViewBag.RisklessCodes = risklessCodes;

            return View(ViewBag);
        }
    }
}