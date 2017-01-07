using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BranchPredictorPro.Helpers
{
    public class PowerOfTwoUpDown : NumericUpDown
    {
        public override void UpButton()
        {
           if(this.Value>=1 && this.Value<=16)
            {
                this.Value *= 2;
                base.UpButton();
            }
           
        }

        public override void DownButton()
        {
            if (this.Value>1)
            {
                this.Value /= 2;
                base.DownButton();
            }
           
        }

    }
}
