﻿using System.Collections.Generic;
using static Randomizer.SMZ3.ItemType;

namespace Randomizer.SMZ3.Regions.Zelda {

    class HyruleCastle : Region {

        public override string Name => "Hyrule Castle";
        public override string Area => "Hyrule Castle";

        public HyruleCastle(World world, Logic logic) : base(world, logic) {
            Locations = new List<Location> {
                new Location(this, 256+91, 0xEA79, LocationType.Regular, "Sanctuary"),
                new Location(this, 256+92, 0xEB5D, LocationType.Regular, "Sewers - Secret Room - Left",
                    items => items.CanLiftLight() || items.Has(Lamp) && items.Has(KeyHC)),
                new Location(this, 256+93, 0xEB60, LocationType.Regular, "Sewers - Secret Room - Middle",
                    items => items.CanLiftLight() || items.Has(Lamp) && items.Has(KeyHC)),
                new Location(this, 256+94, 0xEB63, LocationType.Regular, "Sewers - Secret Room - Right",
                    items => items.CanLiftLight() || items.Has(Lamp) && items.Has(KeyHC)),
                new Location(this, 256+95, 0xE96E, LocationType.Regular, "Sewers - Dark Cross",
                    items => items.Has(Lamp)),
                new Location(this, 256+96, 0xEB0C, LocationType.Regular, "Hyrule Castle - Map Chest"),
                new Location(this, 256+97, 0xE974, LocationType.Regular, "Hyrule Castle - Boomerang Chest",
                    items => items.Has(KeyHC)),
                new Location(this, 256+98, 0xEB09, LocationType.Regular, "Hyrule Castle - Zelda's Cell",
                    items => items.Has(KeyHC)),
                new Location(this, 256+99, 0x2DF45, LocationType.Regular, "Link's Uncle")
                    .Allow((item, items) => /*config.keysanity*/false || !item.IsDungeonItem),
                new Location(this, 256+100, 0xE971, LocationType.Regular, "Secret Passage")
                    .Allow((item, items) => /*config.keysanity*/false || !item.IsDungeonItem),
            };

        }

    }

}