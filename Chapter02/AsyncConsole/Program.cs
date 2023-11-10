HttpClient client = new();
HttpResponseMessage response =
    await client.GetAsync("http://www.netproinnovations.com/");
WriteLine("NETPro Innovations home page has {0:N0} bytes.",
    response.Content.Headers.ContentLength);

