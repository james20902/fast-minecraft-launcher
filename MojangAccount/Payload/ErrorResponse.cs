using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fast_minecraft_launcher.MojangAccount.Payload
{
    class ErrorResponse : IServerResponse
    {
        private string error;
        private string errorMessage;
        //because this field is only sometimes populated, store and display dud string
        private string cause = "";
    }
}
