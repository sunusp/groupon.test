using AutoMapper;
using MvcTests.Models;
using MvcTestsDomainModel;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MvcTests.Controllers
{
    public class InvitationDigitalController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("invitationdigital/tests/{index}")]
        public async Task<ActionResult> Tests(int index = 0)
        {
            TestViewModel testViewModel = null;

            using (HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:49869")
            })
            {
                HttpResponseMessage response = await client.GetAsync($"api/values/{index}");

                if (response.IsSuccessStatusCode)
                {
                    TestDomainModel testDomainModel = await response.Content.ReadAsAsync<TestDomainModel>();
                    testViewModel = Mapper.Map<TestDomainModel, TestViewModel>(testDomainModel);
                }
            }

            return View(testViewModel);
        }


    }
}
