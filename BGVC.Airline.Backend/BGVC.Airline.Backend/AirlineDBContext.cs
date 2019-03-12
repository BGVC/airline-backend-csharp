using BGVC.Airline.Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        public DbSet<City> Cities { get; set; }

        // TODO: VC -> BG: Please check if this should exist or should it be deleted?
        internal void EnsureSeedDataForContext()
        {
            throw new NotImplementedException();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            SeedCountries(modelBuilder);
        }

        private void SeedCountries(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(new Country { Id = 1, Name = "Afghanistan" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 2, Name = "Åland Islands" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 3, Name = "Albania" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 4, Name = "Algeria" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 5, Name = "American Samoa" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 6, Name = "Andorra" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 7, Name = "Angola" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 8, Name = "Anguilla" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 9, Name = "Antarctica" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 10, Name = "Antigua and Barbuda" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 11, Name = "Argentina" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 12, Name = "Armenia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 13, Name = "Aruba" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 14, Name = "Australia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 15, Name = "Austria" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 16, Name = "Azerbaijan" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 17, Name = "Bahrain" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 18, Name = "Bahamas" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 19, Name = "Bangladesh" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 20, Name = "Barbados" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 21, Name = "Belarus" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 22, Name = "Belgium" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 23, Name = "Belize" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 24, Name = "Benin" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 25, Name = "Bermuda" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 26, Name = "Bhutan" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 27, Name = "Bolivia, Plurinational State of" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 28, Name = "Bonaire, Sint Eustatius and Saba" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 29, Name = "Bosnia and Herzegovina" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 30, Name = "Botswana" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 31, Name = "Bouvet Island" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 32, Name = "Brazil" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 33, Name = "British Indian Ocean Territory" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 34, Name = "Brunei Darussalam" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 35, Name = "Bulgaria" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 36, Name = "Burkina Faso" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 37, Name = "Burundi" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 38, Name = "Cambodia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 39, Name = "Cameroon" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 40, Name = "Canada" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 41, Name = "Cape Verde" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 42, Name = "Cayman Islands" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 43, Name = "Central African Republic" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 44, Name = "Chad" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 45, Name = "Chile" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 46, Name = "China" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 47, Name = "Christmas Island" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 48, Name = "Cocos (Keeling) Islands" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 49, Name = "Colombia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 50, Name = "Comoros" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 51, Name = "Congo" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 52, Name = "Congo, the Democratic Republic of the" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 53, Name = "Cook Islands" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 54, Name = "Costa Rica" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 55, Name = "Côte d'Ivoire" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 56, Name = "Croatia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 57, Name = "Cuba" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 58, Name = "Curaçao" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 59, Name = "Cyprus" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 60, Name = "Czech Republic" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 61, Name = "Denmark" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 62, Name = "Djibouti" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 63, Name = "Dominica" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 64, Name = "Dominican Republic" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 65, Name = "Ecuador" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 66, Name = "Egypt" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 67, Name = "El Salvador" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 68, Name = "Equatorial Guinea" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 69, Name = "Eritrea" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 70, Name = "Estonia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 71, Name = "Ethiopia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 72, Name = "Falkland Islands (Malvinas)" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 73, Name = "Faroe Islands" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 74, Name = "Fiji" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 75, Name = "Finland" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 76, Name = "France" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 77, Name = "French Guiana" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 78, Name = "French Polynesia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 79, Name = "French Southern Territories" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 80, Name = "Gabon" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 81, Name = "Gambia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 82, Name = "Georgia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 83, Name = "Germany" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 84, Name = "Ghana" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 85, Name = "Gibraltar" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 86, Name = "Greece" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 87, Name = "Greenland" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 88, Name = "Grenada" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 89, Name = "Guadeloupe" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 90, Name = "Guam" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 91, Name = "Guatemala" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 92, Name = "Guernsey" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 93, Name = "Guinea" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 94, Name = "Guinea-Bissau" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 95, Name = "Guyana" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 96, Name = "Haiti" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 97, Name = "Heard Island and McDonald Islands" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 98, Name = "Holy See (Vatican City State)" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 99, Name = "Honduras" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 100, Name = "Hong Kong" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 101, Name = "Hungary" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 102, Name = "Iceland" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 103, Name = "India" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 104, Name = "Indonesia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 105, Name = "Iran, Islamic Republic of" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 106, Name = "Iraq" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 107, Name = "Ireland" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 108, Name = "Isle of Man" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 109, Name = "Israel" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 110, Name = "Italy" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 111, Name = "Jamaica" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 112, Name = "Japan" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 113, Name = "Jersey" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 114, Name = "Jordan" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 115, Name = "Kazakhstan" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 116, Name = "Kenya" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 117, Name = "Kiribati" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 118, Name = "Korea, Democratic People's Republic of" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 119, Name = "Korea, Republic of" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 120, Name = "Kuwait" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 121, Name = "Kyrgyzstan" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 122, Name = "Lao People's Democratic Republic" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 123, Name = "Latvia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 124, Name = "Lebanon" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 125, Name = "Lesotho" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 126, Name = "Liberia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 127, Name = "Libya" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 128, Name = "Liechtenstein" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 129, Name = "Lithuania" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 130, Name = "Luxembourg" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 131, Name = "Macao" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 132, Name = "Macedonia, the Former Yugoslav Republic of" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 133, Name = "Madagascar" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 134, Name = "Malawi" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 135, Name = "Malaysia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 136, Name = "Maldives" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 137, Name = "Mali" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 138, Name = "Malta" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 139, Name = "Marshall Islands" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 140, Name = "Martinique" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 141, Name = "Mauritania" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 142, Name = "Mauritius" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 143, Name = "Mayotte" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 144, Name = "Mexico" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 145, Name = "Micronesia, Federated States of" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 146, Name = "Moldova, Republic of" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 147, Name = "Monaco" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 148, Name = "Mongolia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 149, Name = "Montenegro" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 150, Name = "Montserrat" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 151, Name = "Morocco" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 152, Name = "Mozambique" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 153, Name = "Myanmar" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 154, Name = "Namibia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 155, Name = "Nauru" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 156, Name = "Nepal" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 157, Name = "Netherlands" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 158, Name = "New Caledonia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 159, Name = "New Zealand" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 160, Name = "Nicaragua" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 161, Name = "Niger" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 162, Name = "Nigeria" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 163, Name = "Niue" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 164, Name = "Norfolk Island" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 165, Name = "Northern Mariana Islands" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 166, Name = "Norway" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 167, Name = "Oman" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 168, Name = "Pakistan" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 169, Name = "Palau" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 170, Name = "Palestine, State of" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 171, Name = "Panama" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 172, Name = "Papua New Guinea" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 173, Name = "Paraguay" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 174, Name = "Peru" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 175, Name = "Philippines" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 176, Name = "Pitcairn" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 177, Name = "Poland" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 178, Name = "Portugal" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 179, Name = "Puerto Rico" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 180, Name = "Qatar" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 181, Name = "Réunion" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 182, Name = "Romania" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 183, Name = "Russian Federation" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 184, Name = "Rwanda" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 185, Name = "Saint Barthélemy" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 186, Name = "Saint Helena, Ascension and Tristan da Cunha" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 187, Name = "Saint Kitts and Nevis" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 188, Name = "Saint Lucia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 189, Name = "Saint Martin (French part)" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 190, Name = "Saint Pierre and Miquelon" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 191, Name = "Saint Vincent and the Grenadines" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 192, Name = "Samoa" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 193, Name = "San Marino" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 194, Name = "Sao Tome and Principe" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 195, Name = "Saudi Arabia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 196, Name = "Senegal" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 197, Name = "Serbia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 198, Name = "Seychelles" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 199, Name = "Sierra Leone" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 200, Name = "Singapore" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 201, Name = "Sint Maarten (Dutch part)" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 202, Name = "Slovakia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 203, Name = "Slovenia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 204, Name = "Solomon Islands" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 205, Name = "Somalia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 206, Name = "South Africa" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 207, Name = "South Georgia and the South Sandwich Islands" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 208, Name = "South Sudan" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 209, Name = "Spain" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 210, Name = "Sri Lanka" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 211, Name = "Sudan" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 212, Name = "Suriname" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 213, Name = "Svalbard and Jan Mayen" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 214, Name = "Swaziland" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 215, Name = "Sweden" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 216, Name = "Switzerland" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 217, Name = "Syrian Arab Republic" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 218, Name = "Taiwan, Province of China" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 219, Name = "Tajikistan" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 220, Name = "Tanzania, United Republic of" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 221, Name = "Thailand" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 222, Name = "Timor-Leste" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 223, Name = "Togo" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 224, Name = "Tokelau" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 225, Name = "Tonga" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 226, Name = "Trinidad and Tobago" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 227, Name = "Tunisia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 228, Name = "Turkey" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 229, Name = "Turkmenistan" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 230, Name = "Turks and Caicos Islands" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 231, Name = "Tuvalu" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 232, Name = "Uganda" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 233, Name = "Ukraine" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 234, Name = "United Arab Emirates" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 235, Name = "United Kingdom" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 236, Name = "United States" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 237, Name = "United States Minor Outlying Islands" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 238, Name = "Uruguay" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 239, Name = "Uzbekistan" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 240, Name = "Vanuatu" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 241, Name = "Venezuela, Bolivarian Republic of" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 242, Name = "Viet Nam" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 243, Name = "Virgin Islands, British" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 244, Name = "Virgin Islands, U.S." });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 245, Name = "Wallis and Futuna" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 246, Name = "Western Sahara" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 247, Name = "Yemen" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 248, Name = "Zambia" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 249, Name = "Zimbabwe" });

        }
    }
}
