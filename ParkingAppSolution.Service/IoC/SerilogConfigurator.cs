﻿using Serilog;

namespace ParkingAppSolution.Service.IoC
{
    public class SerilogConfigurator
    {
        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            builder.Host.UseSerilog((context, loggerConfiguration) =>
                {
                    loggerConfiguration
                        .Enrich.WithCorrelationId()
                        .ReadFrom.Configuration(context.Configuration);
                }
            );

            builder.Services.AddHttpContextAccessor();
        }

        public static void ConfigureApplication(IApplicationBuilder app)
        {
            app.UseSerilogRequestLogging();
        }
    }
}