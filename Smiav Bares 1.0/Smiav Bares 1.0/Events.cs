using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smiav_Bares_1._0 
{
    public static class CompleteEvents
    {
        public delegate void CompleteHandler(CompleteEventArgs args);
        public static event CompleteHandler Complete;

        public static void RaiseEvent(int mesa, string comanda, string garzon)
        {
            if (Complete != null)
                Complete(new CompleteEventArgs(mesa, comanda, garzon));
        }
    }

    public class CompleteEventArgs : EventArgs
    {
        public CompleteEventArgs(int mesa, string comanda, string garzon)
        {
            this.Mesa = mesa;
            this.Comanda = comanda;
            this.Garzon = garzon;
        }

        public int Mesa { get; set; }
        public string Comanda { get; set; }
        public string Garzon { get; set; }
    }
}
