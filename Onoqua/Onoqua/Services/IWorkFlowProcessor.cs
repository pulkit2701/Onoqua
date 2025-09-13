using Onoqua.Entities.Models;
using Onoqua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onoqua.Services
{
    internal interface IWorkFlowProcessor
    {
        void Execute(ref ViewModel model, WorkFlow wf);
    }
}
