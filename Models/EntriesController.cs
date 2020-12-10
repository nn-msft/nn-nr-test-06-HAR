using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace NewRelicDemo_NN_01.Models
{
    //[Route("api/entries")]
    //[ApiController]
    public class EntriesController : Controller
    {
        public IEntrylRepository _entriesRepository { get; set; }

        public EntriesController(IEntrylRepository _entryRepository)
        {
            _entriesRepository = _entryRepository;
        }

        public IEnumerable<Entries> GetAllEntries()
        {

            return _entriesRepository.ListOfEntries();

        }

    
        public async Task<IActionResult> Index()
        {

            List<Entries> entryList = new List<Entries>();
            dynamic data = null;

            string baseUrl = "https://api.publicapis.org/entries";


            using (HttpClient client = new HttpClient())
            {
                

                using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                {

                    using (HttpContent content = res.Content)
                    {

                        // string data = await content.ReadAsStringAsync();

                        //  entryList = JsonConvert.DeserializeObject<List<Entries>>(content.);
                        // Console.WriteLine(content.ToString());
                        //Console.ReadLine();
                        //return View(content.ToString());
                        //string data = await content.ReadAsStringAsync();
                         data = JsonConvert.DeserializeObject<dynamic>(await content.ReadAsStringAsync());

                    }
                }




            }

            //return View(entryList);
            ViewBag.Message = data.ToString();
            return View();

        }

        public async Task<IActionResult> High()
        {

            int num=0;
            for (int i = 0; i < 1000; i++) {

                num = i;
            
            }
            ViewBag.Message = num.ToString();
            return View();
        
        
        }
    }
}
