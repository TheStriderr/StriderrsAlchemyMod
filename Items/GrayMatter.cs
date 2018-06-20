using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace StriderrsAlchemyMod.Items
{
    public class GrayMatter : ModItem
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
          recipe.AddIngredient(ItemID.CobaltOre);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 10);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CobaltBar);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 30);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CobaltHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CobaltMask);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CobaltHat);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CobaltBreastplate);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 600);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CobaltLeggings);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 450);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CobaltDrill);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 450);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CobaltPickaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 450);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CobaltChainsaw);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CobaltWaraxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CobaltRepeater);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CobaltSword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CobaltNaginata);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalladiumOre);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 12);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalladiumBar);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 36);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalladiumMask);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 432);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalladiumHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 432);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalladiumHeadgear);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 432);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalladiumBreastplate);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 864);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalladiumLeggings);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 648);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalladiumDrill);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 648);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalladiumPickaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 648);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalladiumChainsaw);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 432);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalladiumWaraxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 432);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalladiumRepeater);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 432);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalladiumSword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 432);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalladiumPike);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 432);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MythrilOre);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 15);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MythrilBar);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 60);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MythrilAnvil);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 600);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MythrilHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 600);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MythrilHat);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 600);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MythrilHood);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 600);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MythrilChainmail);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1200);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MythrilGreaves);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 900);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MythrilDrill);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 900);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MythrilPickaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 900);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MythrilChainsaw);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 600);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MythrilWaraxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 600);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MythrilRepeater);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 600);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MythrilSword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 600);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.MythrilHalberd);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 600);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.OrichalcumOre);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 17);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.OrichalcumBar);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 68);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.OrichalcumAnvil);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 816);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.OrichalcumMask);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 816);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.OrichalcumHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 816);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.OrichalcumHeadgear);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 816);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.OrichalcumBreastplate);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1632);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.OrichalcumLeggings);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1224);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.OrichalcumDrill);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1224);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.OrichalcumPickaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1224);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.OrichalcumChainsaw);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 816);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.OrichalcumWaraxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 816);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.OrichalcumRepeater);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 816);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.OrichalcumSword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 816);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.OrichalcumHalberd);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 816);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.AdamantiteOre);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 20);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.AdamantiteBar);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 100);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.AdamantiteMask);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1200);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.AdamantiteHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1200);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.AdamantiteHeadgear);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1200);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.AdamantiteBreastplate);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 2400);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.AdamantiteLeggings);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1800);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.AdamantiteDrill);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1800);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.AdamantitePickaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1800);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.AdamantiteChainsaw);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1800);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.AdamantiteWaraxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1200);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.AdamantiteRepeater);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1200);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.AdamantiteSword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1200);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.AdamantiteGlaive);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1200);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TitaniumOre);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 20);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TitaniumBar);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 100);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TitaniumMask);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TitaniumHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TitaniumHeadgear);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TitaniumBreastplate);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 2600);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TitaniumLeggings);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 2000);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TitaniumDrill);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 2000);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TitaniumPickaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 2000);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TitaniumChainsaw);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TitaniumWaraxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TitaniumRepeater);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TitaniumSword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TitaniumTrident);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1300);
          recipe.AddRecipe();
        }

}
}
