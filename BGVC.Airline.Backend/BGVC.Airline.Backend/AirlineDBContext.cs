using BGVC.Airline.Backend.Models;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend
{
    public class AirlineDBContext : DbContext
    {
        public AirlineDBContext(DbContextOptions<AirlineDBContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<IsoRegion> IsoRegions { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }
        public DbSet<AirportType> AirportTypes { get; set; }
        public DbSet<Airport> Airports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            var countries = CreateCountries();
            var isoRegions = CreateIsoRegions(countries);
            var municipalitiesPart1 = CreateMunicipalitiesPart1(isoRegions);
            var airportTypes = CreateAirportTypes();
            var municipalities = municipalitiesPart1;
            var airports = CreateAirports();

            SeedEntities(modelBuilder, countries);
            SeedEntities(modelBuilder, isoRegions);
            SeedEntities(modelBuilder, municipalities);
            SeedEntities(modelBuilder, airportTypes);
            SeedEntities(modelBuilder, airports);
        }

        private static List<IsoRegion> CreateIsoRegions(List<Country> countries)
        {
            var regions = new List<IsoRegion>
            {
                new IsoRegion { Id = 1, Code = "US-NJ", CountryId = countries.Single(country => country.Iso ==  "US").Id },
                new IsoRegion { Id = 2, Code = "RS-05", CountryId = countries.Single(country => country.Iso == "RS").Id },
                new IsoRegion { Id = 3, Code = "RS-16", CountryId = countries.Single(country => country.Iso == "RS").Id },
            };
            return regions;
        }

        private static List<Country> CreateCountries()
        {
            var countries = new List<Country> {
                                new Country { Id = 1, Name = "Serbia", Iso = "RS" },
                                new Country { Id = 2, Name = "United States", Iso = "US" }
            };

            return countries;
        }

        private static List<AirportType> CreateAirportTypes()
        {
            var airportTypes = new List<AirportType>
            {
                new AirportType { Id = 1, Name = "heliport" },
                new AirportType { Id = 2, Name = "small_airport" },
                new AirportType { Id = 3, Name = "closed" },
                new AirportType { Id = 4, Name = "seaplane_base" },
                new AirportType { Id = 5, Name = "balloonport" },
                new AirportType { Id = 6, Name = "medium_airport" },
                new AirportType { Id = 7, Name = "large_airport" }
            };

            return airportTypes;
        }


        private static void SeedEntities<T>(ModelBuilder modelBuilder, List<T> entities) where T : class
        {
            modelBuilder.Entity<T>().HasData(entities);
        }

        private static List<Municipality> CreateMunicipalitiesPart1(List<IsoRegion> isoRegions)
        {
            var municipalities = new List<Municipality>
     {
        new Municipality  { Id = 1, Name = "Los Angeles", IsoRegionId = 1 },
        new Municipality  { Id = 2, Name = "Belgrade", IsoRegionId =  3 },
    };

            return municipalities;
        }

        private static List<Airport> CreateAirports()
        {
            var airports = new List<Airport>
            {
                new Airport { Id = 1, Code = "LAX", TypeId = 7, MunicipalityId = 1, Name = "Los Angeles International Airport" },
                new Airport { Id = 2, Code = "BEG", TypeId = 7, MunicipalityId = 2, Name = "Belgrade Nikola Tesla Airport" }
            };

            return airports;
        }
    }
}
