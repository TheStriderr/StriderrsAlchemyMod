using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace StriderrsAlchemyMod.Items
{
    public class Mk3Matter : ModItem
    {

        public override void SetStaticDefaults()
        {
          DisplayName.SetDefault("Hell Matter");
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
            item.rare = 4;
        }

        public override void AddRecipes()
        {
          ModRecipe recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.Hellstone);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 10);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.HellstoneBar);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 32);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MoltenFury);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 480);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.FieryGreatsword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 640);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MoltenPickaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 640);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MoltenHamaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 480);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.ImpStaff);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 544);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MoltenHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 320);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MoltenBreastplate);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 640);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MoltenGreaves);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 480);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.DarkLance);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 500);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.Flamelash);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 500);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.FlowerofFire);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 500);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.Sunfury);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 500);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.HellwingBow);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 500);
          recipe.AddRecipe();
        }
    }
}
