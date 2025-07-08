using System.Net.Http.Json;
using Microsoft.Extensions.Configuration;


namespace SkyCast.Services;

public class WeatherService
{
    // El servicio WeatherService se encarga de obtener información del clima
    // Se usa HttpClient para realizar peticiones a la API de OpenWeatherMap
    private readonly HttpClient _http;
    private readonly string _key;
    //Diferencia entre readonly y const (En readonly se le puede estar modificando el conteniod de la variable  y en const no)
    private const string _baseUrl = "https://api.openweathermap.org/data/2.5";
    //Se crea el constructor de la clase WeatherService
    //Recibe un HttpClient y una IConfiguration para obtener la clave de la API
    public WeatherService(HttpClient http, IConfiguration config)
    {
        _http = http;
        _key = config["OPENWEATHER_KEY"] ?? "";
    }
    // Método GetWeatherAsync que recibe el nombre de una ciudad y devuelve un objeto WeatherDto
    // que contiene la información del clima de esa ciudad.
    public async Task<WeatherDto?> GetByCityAsync(string city)
    {

        var url = $"{_baseUrl}/weather?q={Uri.EscapeDataString(city)}&units=metric&appid={_key}&lang=es";
        return await _http.GetFromJsonAsync<WeatherDto>(url);
    }
}