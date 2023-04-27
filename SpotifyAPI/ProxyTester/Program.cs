using System.Net.Http.Json;
using System.Text.RegularExpressions;
using Models.DTO.FrontToBack.Auth;

var client = new HttpClient();
var lData = new LoginData(){Identifier = "user1", Password = "12345678"};
var message = new HttpRequestMessage();
var regex = new Regex("(.*?)");
Console.WriteLine(regex.IsMatch("Auth/Login"));
message.Method = HttpMethod.Post;
message.Content = JsonContent.Create(lData);
message.RequestUri = new Uri("https://localhost:7121/Auth/Login");
Console.WriteLine(message.RequestUri.Host);
Console.WriteLine(message.RequestUri.Port);
Console.WriteLine(message.RequestUri.AbsolutePath);
var responseMessage =await client.SendAsync(message);
Console.WriteLine(await responseMessage.Content.ReadAsStringAsync());