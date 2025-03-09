using HubConnectionBuilderSample;

var connection = new HubConnectionBuilder()
          .WithConnectionName("MyTestHub")
          .WithTimeout(60)
          .WithUrl("https://MyTestHubConnectoinUrl/SignalR")
          .WithAuthenticationToken("token-test-123kjhyuuiE%^knvbfgvb12")
          .UseHttps()
          .Build();



connection.Connect();
