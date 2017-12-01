using Newtonsoft.Json;
using System;
using System.Net.Http;
using TseHn2017Application.Dto;

namespace TseHn2017Application.AppCode.Engines
{
    public class FueraJohApiEngine
    {
        public string ServerPath { get; set; }
        public HttpClient Client { get; set; }
        public ActaDto ActaVm { get; set; }

        public FueraJohApiEngine(string serverPath)
        {
            ServerPath = serverPath;
            Client = new HttpClient();
            ActaVm = new ActaDto();
        }


        public ActaDto GetActa(int acta)
        {
            try
            {
                var controller = "/prod/ApiActa/";
                var action = $"Consultar/1/{acta}";
                var completePath = ServerPath + controller + action;

                var client = new HttpClient();
                var json = "{}";
                var actaVm = new ActaDto();

                var task = Client.GetAsync(completePath)
                    .ContinueWith((taskwithresponse) =>
                    {
                        var response = taskwithresponse.Result;
                        var readtask = response.Content.ReadAsStringAsync();
                        json = readtask.Result;

                        actaVm = JsonConvert.DeserializeObject<ActaDto>(json);

                        return actaVm;
                    });
                task.Wait();
                ActaVm = actaVm;
                return actaVm;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return ActaVm;
            }

        }

    }

}
