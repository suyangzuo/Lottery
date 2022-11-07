using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Lottery_WinForm
{
    internal static class Information
    {
        public enum State
        {
            Running, Suspend, Stop
        }

        public static List<string> Names = new();
        public static string? currentName;
        public static State currentState = State.Stop;
        public static readonly object objLock = new();
    }
}
