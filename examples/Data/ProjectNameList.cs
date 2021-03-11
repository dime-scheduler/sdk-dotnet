using System;
using System.Collections.Generic;
using System.Linq;

namespace Dime.Scheduler.Sdk.Samples
{
    public class ProjectNameList : List<string>
    {
        public ProjectNameList()
        {
            List<string> list = new()
            {
                "Amigos", "Antique", "Apollo", "Astro", "Atlantis", "Aurora", "Balto", "Barcelona", "Barney",
                "Barracuda", "Batman", "Bender", "Bigfish", "Bigfoot", "Bladerunner", "Blue Moon", "Blue Skywalkers",
                "Bongo", "Bordeaux", "Bride of Buster", "Bulldozer", "Bullwinkle", "Business as Unusual", "Camelot",
                "Canary", "Casanova", "Cascade", "Cauldron", "Caveman Lawyers", "Charming Chicks", "Cheerio",
                "Cherrystone", "Cinnamon", "Cold Fusion", "Colossus", "Colusa", "Constantine", "Cowbelles", "Crusader",
                "Cyclone", "Dagwood", "Dangerous Rocks", "Darwin", "Deepmind", "DejaVu", "Dessert Storm", "Diesel",
                "Disco Divas", "Disco Ninjas", "Duracell", "Duraflame", "Durango", "Eagle", "Early First", "Echo Lake",
                "Edison", "Einstein", "Elixir", "Elmer", "Excalibur", "Fester", "Fireball", "Firefly", "Firestorm",
                "Firetruck", "Flamingo", "Flyers", "Fusion", "Galactica", "Gemini", "Gold Star", "Golden Bulls",
                "Gray Panthers", "Green Jade", "Hades", "Hercules", "Hidden Hook", "Honeycomb", "Horned Frogs",
                "Hornets", "Husky Cat", "Hydra", "Indigo", "Irongate", "Ivory", "Jaguar", "Jonah", "Jupiter", "Kanga",
                "KingFish", "Kingsmen", "Kodiak", "Kryptonite", "Laguna", "Lemon Drops", "Liberation", "Liquid Sky",
                "Lobster", "Longhorns", "Lorax", "Mad Hatter", "Malibu", "Mango", "Maroon", "Massive Monkey",
                "Matadors", "Mercury", "Metro", "Moonshine", "Mountaineers", "Mustangs", "Nautilus", "Nitro", "Odyssey",
                "Omega", "Orange Dots", "Orion", "Peacocks", "Pharoahs", "Phoenix", "Pink Dragons", "Pink Ladies",
                "Pluto", "Poseidon", "Prelude", "Project X", "Pure Panther", "Python", "Quadro", "Quicksilver",
                "Rampage", "Red Butter", "Revolution", "Rhinestone", "Riviera", "Roadrunner", "Romeo", "Royal",
                "Sahara", "Sea Lions", "Seawolves", "Sirius", "Skyhawks", "Soul Spartans", "Sputnik", "Stratos",
                "Striped Foxes", "Sultans of Sales", "Sunburst", "Sunergy", "The Bomb Squad", "The Violent Storms",
                "Timberwolves", "Titan", "Topaz", "Topcat", "Torpedo", "Tribe", "Vikings", "Vipers", "Voyager",
                "Weekend Warriors", "Westerners", "Whistler", "White Feather", "Wide Stringer", "Wombat", "Xena",
                "Yaeger", "Yellow Moose", "Yoda", "Yosemite", "Zeus", "Zircon", "Zulu",
            };

            AddRange(list);
        }

        public override string ToString()
        {
            Random ran = new();
            int subName1 = ran.Next(Count);
            int subName2 = ran.Next(Count);

            return $"Project {this.ElementAt(subName1)} {this.ElementAt(subName2)}";
        }
    }
}