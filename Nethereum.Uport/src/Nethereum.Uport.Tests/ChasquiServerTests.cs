using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Nethereum.Uport.Tests
{
    public class ChasquiServerTests
    {
        [Fact]
        public async void ShouldGetResponseFromServer()
        {
            var chasquiUrl = "https://chasqui.uport.me/";
            var server = new UportChasquiServer(chasquiUrl);
            var topic = server.NewTopic("address");
            var response = await server.GetResponseAsync(topic);

        }
    }
}
