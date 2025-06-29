// <copyright file="Program.cs" company="Acme Sprocket Co">
// Copyright (c) Acme Sprocket Co. All rights reserved.
// </copyright>

namespace Mono.API
{
    /// <summary>
    /// Main entry class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main entry function.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddOpenApi();

            var app = builder.Build();

            app.MapOpenApi();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}