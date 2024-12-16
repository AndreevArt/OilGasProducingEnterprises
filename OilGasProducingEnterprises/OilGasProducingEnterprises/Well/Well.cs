using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilGasProducingEnterprises.Well
{
    internal class Well
    {
        public int Number { get; set; }
        public string Status { get; set; }
        public Exception[] Exeptions { get; set; }
        public double OilProductionVolume { get; set; }
        public double EnergyConsumption { get; set; }
        public string Region { get; set; }
        public int NumberOfWorkers { get; set; }
        public DateOnly DateTimeOfStartWorking { get; set; }
    }
}
