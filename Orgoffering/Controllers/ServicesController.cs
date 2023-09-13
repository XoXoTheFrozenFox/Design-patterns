using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Orgoffering.Data;
using Orgoffering.Models;
using Orgoffering.Repository;

namespace Orgoffering.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IServiceRepository _serviceRepository;
        public ServicesController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        // GET: Services
        public async Task<IActionResult> Index()
        {
            return View(_serviceRepository.GetAll());
        }
    }
}