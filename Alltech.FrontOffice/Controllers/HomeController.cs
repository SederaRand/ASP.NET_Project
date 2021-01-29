using Alltech.DataAccess.Models;
using Alltech.FrontOffice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Alltech.FrontOffice.Controllers
{

    public class HomeController : Controller
    {

        string baseUrl = "https://localhost:44352/";


        public async Task<ActionResult> Index()
        {
            List<Products> products = new List<Products>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/HomeProducts");
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    products = JsonConvert.DeserializeObject<List<Products>>(EmpResponse);

                }

                return View(products);

            }
        }

        public async Task<ActionResult> Shop(int pageNumber, int pageSize)
        {
            //?pageNumber=2&pageSize=2
            List<Products> products = new List<Products>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

               
                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/HomeProducts/catalogue?pageNumber= " + pageNumber);
                //  + pageNumber + "&pageSize=" + pageSize
                ViewBag.pageNbr = pageNumber;
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    products = JsonConvert.DeserializeObject<List<Products>>(EmpResponse);

                }
               
                return View(products);

            }
        }

        public async Task<ActionResult> Details(int id)
        {
            Products products = new Products();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/ProductsApi/" + id);

                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    products = JsonConvert.DeserializeObject<Products>(EmpResponse);

                }
                return View(products);
            }

        }


        public async Task<ActionResult<IEnumerable<Products>>> Search(string name)
        {
            List<Products> products = new List<Products>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/HomeProducts/search?name=" + name);

                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    products = JsonConvert.DeserializeObject<List<Products>>(EmpResponse);

                }
                return View(products);
            }

        }
    }
}
