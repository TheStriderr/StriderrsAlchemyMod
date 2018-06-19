using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace StriderrsAlchemyMod.Items
{
    public class Mk2Matter : ModItem
    {

        public override void SetStaticDefaults()
        {
          DisplayName.SetDefault("Dark Matter");
          Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
          ItemID.Sets.AnimatesAsSoul[item.type] = true;
          ItemID.Sets.ItemIconPulse[item.type] = true;
          ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {

            item.width = 32;
            item.height = 32;
            item.maxStack = 9999;
            item.rare = 3;
        }

        public override void AddRecipes()
        {
          ModRecipe recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.Meteorite);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 4);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MeteoriteBar);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 12);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MeteorHamaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 240);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SpaceGun);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 240);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MeteorHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 120);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MeteorSuit);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 240);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MeteorLeggings);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 180);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.BluePhaseblade);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 230);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.RedPhaseblade);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 230);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.GreenPhaseblade);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 230);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PurplePhaseblade);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 230);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.WhitePhaseblade);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 230);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.YellowPhaseblade);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 230);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.DemoniteOre);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 10);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.DemoniteBar);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 30);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.FisherofSouls);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 240);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.DemonBow);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 240);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.WarAxeoftheNight);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LightsBane);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.ShadowScale);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 20);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.NightmarePickaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 480);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TheBreaker);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 400);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CorruptYoyo);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 360);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.ShadowHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 650);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.ShadowScalemail);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1150);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.ShadowGreaves);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 900);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CrimtaneOre);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 12);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CrimtaneBar);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 36);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.Fleshcatcher);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 288);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TendonBow);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 288);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.BloodLustCluster);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 360);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.BloodButcherer);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 360);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TissueSample);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 23);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.DeathbringerPickaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 570);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.FleshGrinder);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 475);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CrimsonYoyo);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 432);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TheMeatball);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 475);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CrimsonHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 770);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CrimsonScalemail);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1360);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CrimsonGreaves);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1065);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.Bone);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 20);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.NecroHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 829);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.NecroBreastplate);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1236);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.NecroGreaves);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1032);
          recipe.AddRecipe();
        }
    }
}
