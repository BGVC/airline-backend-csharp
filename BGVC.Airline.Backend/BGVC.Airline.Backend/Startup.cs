using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using BGVC.Airline.Backend.Automapper;
using BGVC.Airline.Backend.Interfaces;
using BGVC.Airline.Backend.Services;
using BGVC.Airline.Backend.Persistence.Repositories;
using BGVC.Airline.Backend.Persistence.Interfaces;

namespace BGVC.Airline.Backend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Setup from https://code-maze.com/net-core-web-api-ef-core-code-first/#GeneratingDatabase
            services.AddDbContext<AirlineDBContext>(opts =>
                opts.UseSqlServer(Configuration["ConnectionString:Airline"])
                .UseLazyLoadingProxies());
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddMvc(options => options.EnableEndpointRouting = false);
            // todo: Select service lifetime appropriately between singleton, transient and scope
            services.AddScoped<IBookingService, BookingService>();
            services.AddScoped<IAirportRepository, AirportRepository>();
            services.AddScoped<IFlightExtraOptionRepository, FlightExtraOptionRepository>();
            services.AddScoped<IFlightRepository, FlightRepository>();
            services.AddScoped<ILuggageOptionRepository, LuggageOptionRepository>();
            services.AddScoped<IPassengerRepository, PassengerRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
