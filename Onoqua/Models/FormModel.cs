using Onoqua.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onoqua.Models
{
    public class FormModel : Form
    {
        public FormModel()
        {
            this.FieldModel = new List<Models.FieldModel>();
        }

        public bool IsFirst { get; set; }
        public bool IsLast { get; set; }
        public List<FieldModel> FieldModel { get; set; }


        
        
    }
}