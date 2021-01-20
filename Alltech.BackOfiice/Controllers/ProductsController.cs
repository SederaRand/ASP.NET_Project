﻿using Alltech.DataAccess.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Alltech.BackOfiice.Controllers
{
    public class ProductsController : Controller
    {
        string baseUrl = "https://localhost:44301/";
        // GET: Products
        public  ActionResult Index()
        {
            return View();

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
                HttpResponseMessage Res = await client.GetAsync("api/Products/" + id);

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

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Products product)
        {
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Products>("api/Products/", product);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(product);
        }
                                   
        
        public async Task<ActionResult> Edit(int id)
        {
            Products products = null;

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Clear();                

                //HTTP GET
                var responseTask = client.GetAsync("api/Products/" + id);
                responseTask.Wait();

                var Res = responseTask.Result;

                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsAsync<Products>();
                    EmpResponse.Wait();

                    products = EmpResponse.Result;
                }
                return View(products);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Products product, int Id)
        {
            Products products = new Products();
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                HttpResponseMessage response = await client.PutAsJsonAsync("api/Products/" + Id, product);
                response.EnsureSuccessStatusCode();
               
                product = await response.Content.ReadAsAsync<Products>();

                return RedirectToAction("Index");
             }
          
        }


        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(baseUrl);

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("api/Products/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }
    }
}