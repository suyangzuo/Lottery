using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_WinForm
{
    public partial class PrizeSettings : Form
    {
        private static bool modifyIsSaved = false;

        public PrizeSettings()
        {
            InitializeComponent();
        }

        public PrizeSettings(Main_Form mainForm)
        {
            InitializeComponent();
        }
    }
}
