using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Bogus.Extensions;

namespace Dime.Scheduler.Sdk.Samples.Data
{
    internal class ResourceFactory
    {
        internal static Import.Resource Create()
        {
            string[] departments = { "Sales", "Marketing", "R&D", "IT", "Warehouse", "Planning", "Accounting" };
            string[] teams = { "Team A", "Team B", "Team C", "Team D", "Team E", "Team F" };

            return new Faker<Import.Resource>()
                   .RuleFor(x => x.SourceApp, (f, u) => "IMPORT")
                   .RuleFor(x => x.SourceType, (f, u) => "IMPORT")
                   .RuleFor(x => x.ResourceNo, (f, u) => f.Random.AlphaNumeric(5))
                   .RuleFor(x => x.ResourceName, (f, u) => f.Name.FullName())
                   .RuleFor(x => x.DisplayName, (f, u) => f.Name.FullName())
                   .RuleFor(x => x.HomeAddress, (f, u) => f.Address.FullAddress())
                   .RuleFor(x => x.HomeStreet, (f, u) => f.Address.StreetAddress())
                   .RuleFor(x => x.HomeStreetNo, (f, u) => "1")
                   .RuleFor(x => x.HomeCity, (f, u) => f.Address.City())
                   .RuleFor(x => x.HomeCountry, (f, u) => f.Address.Country())
                   .RuleFor(x => x.HomePostcode, (f, u) => f.Address.ZipCode())
                   .RuleFor(x => x.Email, (f, u) => f.Internet.Email())
                   .RuleFor(x => x.Phone, (f, u) => f.Phone.PhoneNumber())
                   .RuleFor(x => x.TeamName, (f, u) => f.PickRandom(teams))
                   .RuleFor(x => x.TeamCode, (f, u) => f.Random.AlphaNumeric(10))
                   .RuleFor(x => x.Department, (f, u) => f.PickRandom(departments))
                   .RuleFor(x => x.FreeText1, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeText2, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeText3, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeText4, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeText5, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeText6, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeText7, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeText9, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeText10, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeText11, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeText12, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeText13, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeText14, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeText15, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeText16, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeText17, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeText18, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeText19, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeText20, (f, u) => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                   .RuleFor(x => x.FreeDate1, (f, u) => f.Date.Future())
                   .RuleFor(x => x.FreeDate2, (f, u) => f.Date.Future())
                   .RuleFor(x => x.FreeDate3, (f, u) => f.Date.Future())
                   .RuleFor(x => x.FreeDate4, (f, u) => f.Date.Future())
                   .RuleFor(x => x.FreeDate5, (f, u) => f.Date.Future())
                   .RuleFor(x => x.FreeDecimal1, (f, u) => f.Random.Number())
                   .RuleFor(x => x.FreeDecimal2, (f, u) => f.Random.Number())
                   .RuleFor(x => x.FreeDecimal3, (f, u) => f.Random.Number())
                   .RuleFor(x => x.FreeDecimal4, (f, u) => f.Random.Number())
                   .RuleFor(x => x.FreeDecimal5, (f, u) => f.Random.Number())
                   .RuleFor(x => x.FreeBit1, (f, u) => f.Random.Bool())
                   .RuleFor(x => x.FreeBit2, (f, u) => f.Random.Bool())
                   .RuleFor(x => x.FreeBit3, (f, u) => f.Random.Bool())
                   .RuleFor(x => x.FreeBit4, (f, u) => f.Random.Bool())
                   .RuleFor(x => x.FreeBit5, (f, u) => f.Random.Bool())
                   .Generate();
        }
    }
}
