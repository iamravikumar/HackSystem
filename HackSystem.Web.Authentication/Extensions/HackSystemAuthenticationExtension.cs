﻿using System;
using HackSystem.Web.Authentication.Options;
using HackSystem.Web.Authentication.Providers;
using HackSystem.Web.Authentication.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace HackSystem.Web.Authentication.Extensions
{
    public static class HackSystemAuthenticationExtension
    {
        public static IServiceCollection AddHackSystemAuthentication(this IServiceCollection services, Action<HackSystemAuthenticationOptions> configure)
        {
            services
                .Configure(configure)
                .AddScoped<IJWTParserService, JWTParserService>()
                .AddScoped<IHackSystemAuthenticationStateProvider, HackSystemAuthenticationStateProvider>()
                .AddScoped<AuthenticationStateProvider, HackSystemAuthenticationStateProvider>();

            return services;
        }
    }
}