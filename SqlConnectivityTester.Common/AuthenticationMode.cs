using System;
using System.Collections.Generic;
using System.Text;

namespace SqlConnectivityTester.Common
{

    public enum AuthenticationMode
    {
        Windows = 0,
        SQLServer = 1,
        ActiveDirectoryPasswordAuthentication = 2,
        ActiveDirectoryIntegratedSecurity = 3
    }
}
