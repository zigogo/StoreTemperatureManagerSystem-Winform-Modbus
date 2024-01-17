using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.UControls
{
    public class UStoreRegionArgs:EventArgs
    {

        public int SId { get; set; }
        public int SRegionId { get; set; }
        public int TemperState { get; set; }
        public decimal SRTemperature { get; set; }

        public decimal LowTemperature { get; set; }
        public decimal HighTemperature { get; set; }

        public UStoreRegionArgs(int sid, int regionId, int temperState, decimal lowTemperature, decimal highTemperature)
        {
            this.SId = sid;
            this.SRegionId = regionId;
            this.TemperState = temperState;
            this.LowTemperature = lowTemperature;
            this.HighTemperature = highTemperature;
        }

        public UStoreRegionArgs(int regionId, int temperState, decimal srTemperature)
        {
            this.SRegionId = regionId;
            this.TemperState = temperState;
            this.SRTemperature = srTemperature;
        }
    }
}
