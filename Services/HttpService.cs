using System.Net.Http.Json;

namespace MauiVideo.Services;
public class HttpService(HttpClient httpClient) {
    public async Task<T?> GetAsync<T>(string url) {

        try {

            var respose = await httpClient.GetAsync(url);
            if(respose != null && respose.IsSuccessStatusCode) {

                var data = await respose.Content.ReadFromJsonAsync<T>();
                return data!;
            }

        } catch(Exception e) {


        }

        return default;
    }
}
