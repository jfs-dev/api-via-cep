static void ConsultarCEP()
{
    var httpClient = new HttpClient();

    var response = httpClient.GetAsync("https://viacep.com.br/ws/01001000/json/").Result;

    var content = response.Content.ReadAsStringAsync().Result;

    Console.WriteLine(content);
}

Console.WriteLine("Testando API Via CEP");
Console.WriteLine("--------------------");
ConsultarCEP();

Console.ReadKey();