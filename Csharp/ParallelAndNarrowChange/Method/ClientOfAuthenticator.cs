using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelAndNarrowChange.Method {
public class ClientOfAuthenticator(AuthenticationService authenticationService)
{
    public static void Main(String[] args) {
        new ClientOfAuthenticator(new AuthenticationService()).Run();
    }

    public void Run() {
        bool authenticated = authenticationService.IsAuthenticated(33);
        Console.WriteLine("33 is authenticated = " + authenticated);
    }
}
}
