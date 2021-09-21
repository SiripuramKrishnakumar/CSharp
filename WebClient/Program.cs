using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace WebClient1
{
    public class Commodity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal UnitValue { get; set; }
        public string UOM { get; set; }
        public int Quanity { get; set; }

    }
    class Program
    {
        static void Main()
        {

            Console.WriteLine("\nCommoditys List");
            List<Commodity> Commoditylist = new List<Commodity>();
            using (var webClient = new System.Net.WebClient())
            {
                webClient.Headers["Content-Type"] = "application/json";
                webClient.BaseAddress = "http://localhost:65116/api/";
                string response = webClient.DownloadString("Home/GetCommodities/");
                Commoditylist = JsonConvert.DeserializeObject<List<Commodity>>(response);
            }
            foreach (var _commodtiy in Commoditylist)
            {
                Console.WriteLine($"CommodityId= {_commodtiy.Id} , Commodity Name = {_commodtiy.Description}");
            }



        start:
            Console.WriteLine("Opions =>  A: Commodity Details; B: Create Commodity; C: Update Commodity; D: Delete Commodity; E: Exit Commodity; ");

            string option = Console.ReadKey().Key.ToString().ToUpper();

            switch (option)
            {
                   
                case "A":
                    Console.WriteLine("\nEnter Commodity Id");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    using (var webClient = new System.Net.WebClient())
                    {
                        webClient.Headers["Content-Type"] = "application/json";
                        webClient.BaseAddress = "http://localhost:65116/api/";
                        string response = webClient.DownloadString("Home/Commodity/GetCommodity/" + Id);
                        Commodity _commodtiy = JsonConvert.DeserializeObject<Commodity>(response);
                        Console.WriteLine($"CommodityId= {_commodtiy.Id} , Commodity Name = {_commodtiy.Description}");
                    }
                    
                    goto start;

                case "B":
                    Commodity Commodity1 = new Commodity();
                    Console.WriteLine("\nEnter Commodity Id");
                    Commodity1.Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Commodity Name");
                    Commodity1.Description = Console.ReadLine();
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                        var response = webClient.UploadString("http://localhost:65116/api/Home/Commodity/SaveCommodity/", JsonConvert.SerializeObject(Commodity1));
                        List<Commodity> Commoditylist1 = JsonConvert.DeserializeObject<List<Commodity>>(response);
                        foreach (var _commodtiy in Commoditylist1)
                        {
                            Console.WriteLine($"CommodityId= {_commodtiy.Id} , Commodity Name = {_commodtiy.Description}");
                        }
                    }
                    goto start;

                case "C":
                    Commodity Commodity2 = new Commodity();
                    Console.WriteLine("\nEnter Commodity Id");
                    Commodity2.Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Commodity Name");
                    Commodity2.Description = Console.ReadLine();
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                        string inp = JsonConvert.SerializeObject(Commodity2);
                        var response = webClient.UploadString("http://localhost:65116/api/Home/Commodity/UpdateCommodity/", WebRequestMethods.Http.Put,inp );
                        Commodity _commodtiy = JsonConvert.DeserializeObject<Commodity>(response);
                        Console.WriteLine($" CommodityId= {_commodtiy.Id} ,Updated Commodity Name = {_commodtiy.Description}");
                    }
                    goto start;
                case "D":
                    Console.WriteLine("\nEnter Commodity Id");
                    int Id1 = Convert.ToInt32(Console.ReadLine());
                    using (HttpClient client = new HttpClient())
                    {

                        client.BaseAddress = new Uri("http://localhost:65116/api/");
                        HttpResponseMessage result = client.DeleteAsync("Home/Commodity/" + Id1).Result;
                        if (result.IsSuccessStatusCode)
                        {
                            Console.WriteLine("Commodity is Deleted");
                        }

                        List<Commodity> Commoditylist1 = JsonConvert.DeserializeObject<List<Commodity>>(result.Content.ReadAsStringAsync().Result);
                        foreach (var _commodtiy in Commoditylist1)
                        {
                            Console.WriteLine($"CommodityId= {_commodtiy.Id} , Commodity Name = {_commodtiy.Description}");
                        }

                    }
                    goto start;
                case "E":
                    break;
                default:
                    break;

            }


        }
    }
   
}
