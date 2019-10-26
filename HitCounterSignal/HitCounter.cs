using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HitCounterSignal
{
    [HubName("hitCounter")]
    public class HitCounter : Hub
    {
        static string _hitcount = "<br>I am so sorry my dear bestie Deepika " + 0 + "<br>";
        static int _count = 0;
        public void RecordHit()
        {
            _count += 1;
            _hitcount += "<br>I am so sorry my dear bestie Deepika " + _count + "<br>";
            Clients.All.onRecordHit(_hitcount);
        }
    }
}