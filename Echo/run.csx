using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage request, out string myOutputBlob, TraceWriter log)
{
    object requestBody = await request.Content.ReadAsAsync<object>();
    myOutputBlob = requestBody;
    return request.CreateResponse(HttpStatusCode.OK, requestBody);
}
