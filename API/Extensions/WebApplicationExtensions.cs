using API.Middleware;
using BusinessLayer.DTOs;
using System.Text.RegularExpressions;

namespace API.Extensions;

public static class WebApplicationExtensions
{
    public static void Configure(this WebApplication app)
    {
        app.UseMiddleware<ExceptionMiddleware>();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();
    }

}