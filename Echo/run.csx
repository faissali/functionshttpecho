using System.Net;

/*public static async Task<HttpResponseMessage> Run(HttpRequestMessage request, out string myOutputBlob, ILogger log)
{
    object requestBody = await request.Content.ReadAsAsync<object>();
    myOutputBlob = requestBody;
    return request.CreateResponse(HttpStatusCode.OK, requestBody);
}*/

public static void Run(HttpRequestMessage request, out string myOutputBlob, ILogger log)
{
    object requestBody = await request.Content.ReadAsAsync<object>();
    log.LogInformation($"C# Queue trigger function processed: {requestBody}");
    myOutputBlob = requestBody;
}
