using System;
using System.Collections.Generic;
using System.Text;

namespace SqlConnectivityTester.Common
{
    public class ServerProperty
    {
        public string MachineName { get; set;}
        public string ServerName { get; set; }
        public string InstanceName { get; set; }
        public int IsClustered { get; set; }
        public string ComputerNamePhysicalNetBIOS { get; set; }
        public string Edition { get; set; }
        public string ProductLevel { get; set; }
        public string ProductVersion { get; set; }
        public int ProcessID { get; set; }
        public string Collation { get; set; }
        public int IsIntegratedSecurityOnly { get; set; }
        public int IsHadrEnabled { get; set; }
        public string HadrManagerStatus { get; set; }
    }
}
