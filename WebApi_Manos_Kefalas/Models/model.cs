using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_Manos_Kefalas.Models
{
    [Serializable]
    public class CreateCustomerViewModel
    {
        public int Id { set; get; }
        public string Name { set; get; }
    }

}