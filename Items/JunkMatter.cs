using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace StriderrsAlchemyMod.Items
{
    public class JunkMatter : ModItem
    {

        public override void SetStaticDefaults()
        {
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
            item.rare = 2;
        }

        public override void AddRecipes()
        {
          ModRecipe recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.DirtBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MudBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.StoneBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 5);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MudstoneBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 6);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.GraniteBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 10);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MarbleBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 10);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.EbonstoneBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 25);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CrimstoneBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 25);
          recipe.AddRecipe();


          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PearlstoneBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 25);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SandBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.EbonsandBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 5);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CrimsandBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 5);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PearlsandBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 5);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.Sandstone);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 5);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CorruptSandstone);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 25);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CrimsonSandstone);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 25);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.HallowSandstone);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 25);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.HardenedSand);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 5);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CorruptHardenedSand);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 25);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CrimsonHardenedSand);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 25);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.HallowHardenedSand);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 25);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.ClayBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 35);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.AshBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 5);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SiltBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 5);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SnowBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 2);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.IceBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 10);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PurpleIceBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 25);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.RedIceBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 25);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PinkIceBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 25);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SlushBlock);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1);
          recipe.AddRecipe();
        }
    }
}
