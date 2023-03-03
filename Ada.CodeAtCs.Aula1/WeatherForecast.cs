﻿namespace Ada.CodeAtCs.Aula1;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}


public class Config
{
    public string UrlDoBancoDeDados { get; set; }
    public string UrlApiDeBuscarCep { get; set; }
}

