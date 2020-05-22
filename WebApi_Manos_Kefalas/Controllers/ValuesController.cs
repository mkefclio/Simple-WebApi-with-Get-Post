using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web.Hosting;
using System.Web.Http;
using System.Xml;
using WebApi_Manos_Kefalas.Models;

namespace WebApi_Manos_Kefalas.Controllers
{
    [Serializable]
    public class ValuesController : ApiController
    {
        // GET api/values/get
        //http://localhost:50711/api/values/get/
        [HttpGet]
        public JObject Get()
        {
            CreateCustomerViewModel vmCustomer = new CreateCustomerViewModel();
            try
            {
                string[] iCustomer = System.IO.File.ReadAllLines(HostingEnvironment.ApplicationPhysicalPath + "/customer.txt");

                vmCustomer.Id = Convert.ToInt32(iCustomer[0].ToString());
                vmCustomer.Name = iCustomer[1];
            }
            catch
            {
                throw;
            }

            return JObject.FromObject(vmCustomer);
        }



        // POST api/values/save
        //http://localhost:50711/api/values/save/
        public JObject Save(JObject jsonResult)
        {
            try
            {
                CreateCustomerViewModel vmCustomer = JsonConvert.DeserializeObject<CreateCustomerViewModel>(jsonResult.ToString());
                string[] iCustomer = { vmCustomer.Id.ToString(), vmCustomer.Name };
                System.IO.File.WriteAllLines(HostingEnvironment.ApplicationPhysicalPath + "/customer.txt", iCustomer);
            }
            catch
            {
                throw;
            }
            
            return jsonResult;
        }

    }
}
