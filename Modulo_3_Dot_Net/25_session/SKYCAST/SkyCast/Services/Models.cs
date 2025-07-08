namespace SkyCast.Services;
//Se construye  el DTO para la API de OpenWeatherMap
// Este DTO se utiliza para mapear la respuesta de la API a un objeto C#
// que se puede utilizar en la aplicación.

//DTO principal que contiene la información del clima de los dos siguientes records
public record WeatherDto(string Name, MainData main, IEnumerable<WeatherInfo> Weather);

public record MainData(double Temp, double Humidity);

public record WeatherInfo(string Description, string Icon);