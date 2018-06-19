using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace StriderrsAlchemyMod.Items
{
    public class BasicMatter : ModItem
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
          recipe.AddIngredient(ItemID.Wood);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 5);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.RichMahogany);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 5);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.Ebonwood);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 5);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.Shadewood);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 5);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.BorealWood);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 5);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalmWood);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 5);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.DynastyWood);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 30);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.WoodFishingPole);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 40);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.WoodHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 100);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.WoodBreastplate);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 150);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.WoodGreaves);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 125);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.WoodenSword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 35);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.WoodenHammer);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 40);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.WoodenBow);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 50);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.WoodYoyo);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 50);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.RichMahoganyHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 100);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.RichMahoganyBreastplate);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 150);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.RichMahoganyGreaves);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 125);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.RichMahoganySword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 35);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.RichMahoganyHammer);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 40);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.RichMahoganyBow);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 50);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.EbonwoodHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 100);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.EbonwoodBreastplate);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 150);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.EbonwoodGreaves);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 125);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.EbonwoodSword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 35);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.EbonwoodHammer);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 40);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.EbonwoodBow);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 50);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.ShadewoodHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 100);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.ShadewoodBreastplate);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 150);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.ShadewoodGreaves);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 125);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.ShadewoodSword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 35);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.ShadewoodHammer);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 40);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.ShadewoodBow);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 50);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalmWoodHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 100);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalmWoodBreastplate);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 150);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalmWoodGreaves);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 125);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalmWoodSword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 35);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalmWoodHammer);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 40);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PalmWoodBow);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 50);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.Silk);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 25);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.Robe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 500);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CopperBar);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 12);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CopperOre);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 4);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CopperPickaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 164);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CopperAxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 123);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CopperHammer);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 135);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CopperShortsword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 84);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CopperBroadsword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 96);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CopperBow);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 84);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CopperHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 180);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CopperChainmail);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.CopperGreaves);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 240);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.Amethyst);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 15);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.AmethystStaff);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 240);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.AmethystRobe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 650);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.AmethystHook);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 225);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LargeAmethyst);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 225);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TinBar);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 12);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TinOre);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 4);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TinPickaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 164);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TinAxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 123);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TinHammer);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 135);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TinShortsword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 84);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TinBroadsword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 96);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TinBow);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 84);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TinHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 180);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TinChainmail);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TinGreaves);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 240);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.Topaz);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 17);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TopazStaff);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 256);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TopazRobe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 670);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LargeTopaz);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 255);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.IronOre);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 7);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.IronBar);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 21);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.IronAnvil);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 105);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.IronAxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 204);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.IronHammer);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 225);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.IronPickaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 267);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.IronShortsword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 147);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.IronBroadsword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 168);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.IronBow);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 147);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.IronHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 420);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.IronChainmail);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 630);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.IronGreaves);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 525);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LeadOre);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 7);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LeadBar);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 21);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LeadAnvil);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 105);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LeadAxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 204);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LeadHammer);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 225);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LeadPickaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 267);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LeadShortsword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 147);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LeadBroadsword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 168);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LeadBow);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 147);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LeadHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 420);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LeadChainmail);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 630);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LeadGreaves);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 525);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SilverOre);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 10);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SilverBar);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 40);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SilverPickaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 272);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SilverAxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 204);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SilverHammer);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 255);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SilverShortsword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 240);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SilverBroadsword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 320);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SilverBow);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 280);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SilverHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 800);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SilverChainmail);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1200);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SilverGreaves);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1000);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.Sapphire);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 42);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SapphireStaff);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 736);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SapphireRobe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 920);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.SapphireHook);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 630);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LargeSapphire);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 630);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TungstenOre);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 10);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TungstenBar);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 40);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TungstenPickaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 272);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TungstenAxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 204);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TungstenHammer);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 255);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TungstenShortsword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 240);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TungstenBroadsword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 320);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TungstenBow);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 280);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TungstenHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 800);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TungstenChainmail);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1200);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.TungstenGreaves);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1000);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.Emerald);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 44);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.EmeraldStaff);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 752);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.EmeraldRobe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 940);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.EmeraldHook);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 660);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LargeEmerald);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 660);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.GoldOre);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 13);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.GoldBar);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 52);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.GoldPickaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 644);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.GoldAxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 483);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.GoldHammer);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 535);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.GoldShortsword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 364);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.GoldBroadsword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 416);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.GoldBow);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 364);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.GoldHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.GoldChainmail);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1820);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.GoldGreaves);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1560);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.Ruby);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 54);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.RubyStaff);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 952);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.RubyRobe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1040);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.RubyHook);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 810);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LargeRuby);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 810);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PlatinumOre);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 13);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PlatinumBar);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 52);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PlatinumPickaxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 644);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PlatinumAxe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 483);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PlatinumHammer);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 535);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PlatinumShortsword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 364);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PlatinumBroadsword);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 416);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PlatinumBow);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 364);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PlatinumHelmet);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1300);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PlatinumChainmail);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1820);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.PlatinumGreaves);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1560);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.Diamond);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 60);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.DiamondStaff);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1000);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.DiamondRobe);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1100);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.DiamondHook);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 900);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.LargeDiamond);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 900);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.Obsidian);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 40);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.ObsidianSkull);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 800);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.ObsidianHelm);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1050);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.ObsidianShirt);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1050);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.ObsidianPants);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(this, 1050);
          recipe.AddRecipe();
        }
    }
}
