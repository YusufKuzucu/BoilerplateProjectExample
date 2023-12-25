using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Controllers; 
using MicroWebExample.Application.Dto.BlogDto;
using MicroWebExample.Application.Dto.ContactDto;
using MicroWebExample.Application.Interfaces;
using Newtonsoft.Json;
using System.Threading.Tasks; 

namespace MicroWebExample.Web.Controllers
{
    public class DefaultController : AbpController
    {
        private readonly IBlogAppService _blogAppService;
        private readonly ISliderAppService _sliderAppService;
        private readonly IContactAppService _contactAppService;

        public DefaultController(IBlogAppService blogAppService, ISliderAppService sliderAppService, IContactAppService contactAppService)
        {
            _blogAppService = blogAppService;
            _sliderAppService = sliderAppService;
            _contactAppService = contactAppService;
        }

        public async Task<IActionResult> Index()
        {
            var sliders = await _sliderAppService.ListAllAsync();
            return View(sliders);
        }

        public async Task<IActionResult> GetSlider()
        {
            var slider = JsonConvert.SerializeObject(await _sliderAppService.ListAllAsync());
            return Json(slider);
        }

        public async Task<IActionResult> Blog()
        {
            var blogs = await _blogAppService.ListAllAsync();
            return View(blogs);
        }

        public async Task<IActionResult> BlogDetail(int id)
        {
            var blogDetail = await _blogAppService.GetBlogById(id);
            return View(blogDetail);
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddContact(CreateContactInput createContact)
        {
            await _contactAppService.Create(createContact);
            return RedirectToAction("Contact", "Default"); 
        }
    }
}
