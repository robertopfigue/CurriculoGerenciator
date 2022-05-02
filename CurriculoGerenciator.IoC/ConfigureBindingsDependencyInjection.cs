﻿using Microsoft.Extensions.DependencyInjection;

namespace CurriculoGerenciator.IoC
{
    public static class ConfigureBindingsDependencyInjection
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            ConfigureBindingsServices.RegisterBindings(services);
        }
    }
}
