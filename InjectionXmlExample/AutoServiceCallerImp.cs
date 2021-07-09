using InjectionXmlExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectionXmlExample
{
    public class AutoServiceCallerImp : AutoServiceCaller
    {
        private AutoService BMWAutoService;
        private AutoService FordAutoService;
        private AutoService HondaAutoService;

        public AutoServiceCallerImp(AutoService bMWAutoService, AutoService fordAutoService, AutoService hondaAutoService)
        {
            BMWAutoService = bMWAutoService;
            FordAutoService = fordAutoService;
            HondaAutoService = hondaAutoService;
        }

        public void CallAutoService()
        {
            BMWAutoService.GetService();
            FordAutoService.GetService();
            HondaAutoService.GetService();
        }
    }
}
