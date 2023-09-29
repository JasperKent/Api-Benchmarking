using BenchmarkDotNet.Attributes;

namespace ApiBenchmarking
{
    public class Benchmarks
    {
        private static readonly HttpClient _httpClient = new();

        private static string CallGet(string url)
        {
            var response = _httpClient.GetAsync(url).Result;

            var forecasts = response.Content.ReadAsStringAsync().Result;

            return forecasts;
        }

        [Benchmark]
        public string UsingMinimalApi()
        {
            return CallGet("https://localhost:7032/weatherforecast");
        }

        [Benchmark(Baseline = true)]
        public string UsingControllerApi()
        {
            return CallGet("https://localhost:7124/weatherforecast");
        }
    }
}
