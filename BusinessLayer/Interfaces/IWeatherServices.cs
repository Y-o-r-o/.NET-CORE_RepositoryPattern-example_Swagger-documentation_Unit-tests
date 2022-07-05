﻿using BusinessLayer.DTOs;
using Core;

namespace BusinessLayer.Interfaces;

public interface IWeatherServices
{
    public Task<MainForecastDTO> GetWeatherAsync(double latitude, double longtitude);
    
    public Task<MainForecastDTO> GetWeatherAsync(CityDTO city);
}
