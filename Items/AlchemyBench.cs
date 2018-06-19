using Terraria.ID;
using Terraria.ModLoader;

namespace StriderrsAlchemyMod.Items
{
    public class AlchemyBench : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Alchemy Bench Mk1");
            Tooltip.SetDefault("A workbench with the power to bend matter.");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 14;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 150;
            item.createTile = mod.TileType("AlchBench");
        }

        public override void AddRecipes()
        {
          ModRecipe recipe = new ModRecipe(mod);
          recipe.AddIngredient(ItemID.ManaCrystal, 5);
          recipe.AddIngredient(ItemID.WorkBench);
          recipe.AddTile(TileID.WorkBenches);
          recipe.SetResult(this);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.DirtBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.MudBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 5);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.StoneBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 6);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.MudstoneBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 10);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.GraniteBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 10);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.MarbleBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 25);
          recipe.AddIngredient(null, "Mk2Matter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.EbonstoneBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 25);
          recipe.AddIngredient(null, "Mk2Matter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CrimstoneBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 25);
          recipe.AddIngredient(null, "LightMatter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PearlstoneBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SandBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 5);
          recipe.AddIngredient(null, "Mk2Matter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.EbonsandBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 5);
          recipe.AddIngredient(null, "Mk2Matter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CrimsandBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 5);
          recipe.AddIngredient(null, "LightMatter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PearlsandBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 5);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Sandstone);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 25);
          recipe.AddIngredient(null, "Mk2Matter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CorruptSandstone);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 25);
          recipe.AddIngredient(null, "Mk2Matter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CrimsonSandstone);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 25);
          recipe.AddIngredient(null, "LightMatter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.HallowSandstone);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 5);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.HardenedSand);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 25);
          recipe.AddIngredient(null, "Mk2Matter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CorruptHardenedSand);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 25);
          recipe.AddIngredient(null, "Mk2Matter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CrimsonHardenedSand);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 5);
          recipe.AddIngredient(null, "LightMatter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.HallowHardenedSand);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 35);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.ClayBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 5);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.AshBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 5);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SiltBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 2);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SnowBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 10);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.IceBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 25);
          recipe.AddIngredient(null, "Mk2Matter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PurpleIceBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 25);
          recipe.AddIngredient(null, "Mk2Matter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.RedIceBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 25);
          recipe.AddIngredient(null, "LightMatter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PinkIceBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "JunkMatter", 1);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SlushBlock);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 5);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Wood);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 5);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.RichMahogany);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 5);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Ebonwood);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 5);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Shadewood);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 5);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.BorealWood);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 5);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PalmWood);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 30);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.DynastyWood);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 40);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.WoodFishingPole);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 100);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.WoodHelmet);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 150);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.WoodBreastplate);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 125);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.WoodGreaves);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 35);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.WoodenSword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 40);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.WoodenHammer);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 50);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.WoodenBow);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 50);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.WoodYoyo);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 100);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.RichMahoganyHelmet);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 150);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.RichMahoganyBreastplate);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 125);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.RichMahoganyGreaves);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 35);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.RichMahoganySword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 40);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.RichMahoganyHammer);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 50);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.RichMahoganyBow);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 100);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.EbonwoodHelmet);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 150);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.EbonwoodBreastplate);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 125);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.EbonwoodGreaves);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 35);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.EbonwoodSword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 40);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.EbonwoodHammer);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 50);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.EbonwoodBow);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 100);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.ShadewoodHelmet);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 150);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.ShadewoodBreastplate);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 125);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.ShadewoodGreaves);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 35);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.ShadewoodSword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 40);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.ShadewoodHammer);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 50);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.ShadewoodBow);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 100);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PalmWoodHelmet);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 150);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PalmWoodBreastplate);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 125);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PalmWoodGreaves);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 35);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PalmWoodSword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 40);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PalmWoodHammer);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 50);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PalmWoodBow);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 25);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Silk);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 500);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Robe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 12);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CopperBar);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 4);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CopperOre);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 164);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CopperPickaxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 123);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CopperAxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 135);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CopperHammer);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 84);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CopperShortsword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 96);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CopperBroadsword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 84);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CopperBow);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 180);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CopperHelmet);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 300);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CopperChainmail);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 340);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CopperGreaves);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 15);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Amethyst);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 240);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.AmethystStaff);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 650);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.AmethystRobe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 650);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LargeAmethyst);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 12);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TinBar);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 4);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TinOre);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 164);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TinPickaxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 123);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TinAxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 135);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TinHammer);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 84);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TinShortsword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 96);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TinBroadsword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 84);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TinBow);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 180);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TinHelmet);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 300);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TinChainmail);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 340);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TinGreaves);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 17);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Topaz);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 256);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TopazStaff);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 670);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TopazRobe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 255);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LargeTopaz);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 7);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.IronOre);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 21);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.IronBar);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 105);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.IronAnvil);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 204);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.IronAxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 225);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.IronHammer);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 267);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.IronPickaxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 147);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.IronShortsword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 168);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.IronBroadsword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 147);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.IronBow);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 420);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.IronHelmet);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 630);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.IronChainmail);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 525);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.IronGreaves);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 7);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LeadOre);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 21);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LeadBar);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 105);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LeadAnvil);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 204);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LeadAxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 225);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LeadHammer);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 267);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LeadPickaxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 147);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LeadShortsword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 168);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LeadBroadsword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 147);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LeadBow);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 420);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LeadHelmet);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 630);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LeadChainmail);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 525);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LeadGreaves);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 10);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SilverOre);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 40);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SilverBar);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 272);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SilverPickaxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 204);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SilverAxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 225);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SilverHammer);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 240);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SilverShortsword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 320);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SilverBroadsword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 280);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SilverBow);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 800);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SilverHelmet);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 1200);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SilverChainmail);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 1000);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SilverGreaves);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 42);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Sapphire);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 736);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SapphireStaff);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 920);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SapphireRobe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 630);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SapphireHook);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 630);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LargeSapphire);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 10);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TungstenOre);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 40);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TungstenBar);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 272);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TungstenPickaxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 204);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TungstenAxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 225);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TungstenHammer);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 240);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TungstenShortsword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 320);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TungstenBroadsword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 280);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TungstenBow);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 800);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TungstenHelmet);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 1200);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TungstenChainmail);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 1000);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TungstenGreaves);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 44);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Emerald);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 752);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.EmeraldStaff);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 940);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.EmeraldRobe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 660);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.EmeraldHook);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 660);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LargeEmerald);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 13);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.GoldOre);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 52);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.GoldBar);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 644);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.GoldPickaxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 483);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.GoldAxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 535);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.GoldHammer);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 364);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.GoldShortsword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 416);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.GoldBroadsword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 364);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.GoldBow);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 1300);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.GoldHelmet);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 1820);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.GoldChainmail);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 1560);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.GoldGreaves);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 54);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Ruby);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 952);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.RubyStaff);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 1040);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.RubyRobe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 810);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.RubyHook);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 810);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LargeRuby);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 13);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PlatinumOre);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 52);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PlatinumBar);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 644);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PlatinumPickaxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 483);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PlatinumAxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 535);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PlatinumHammer);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 364);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PlatinumShortsword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 416);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PlatinumBroadsword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 364);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PlatinumBow);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 1300);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PlatinumHelmet);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 1820);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PlatinumChainmail);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 1560);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PlatinumGreaves);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 60);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Diamond);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 1000);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.DiamondStaff);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 1100);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.DiamondRobe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 900);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.DiamondHook);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 900);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LargeDiamond);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 40);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Obsidian);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 800);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.ObsidianSkull);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 1050);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.ObsidianHelm);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 1050);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.ObsidianShirt);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "BasicMatter", 1050);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.ObsidianPants);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 4);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Meteorite);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 12);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.MeteoriteBar);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 240);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.MeteorHamaxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 240);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.SpaceGun);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 120);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.MeteorHelmet);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 240);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.MeteorSuit);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 180);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.MeteorLeggings);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 230);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.BluePhaseblade);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 230);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.RedPhaseblade);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 230);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.GreenPhaseblade);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 230);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.PurplePhaseblade);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 230);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.WhitePhaseblade);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 230);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.YellowPhaseblade);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 10);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.DemoniteOre);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 30);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.DemoniteBar);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 240);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.FisherofSouls);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 240);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.DemonBow);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 300);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.WarAxeoftheNight);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 300);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.LightsBane);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 20);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.ShadowScale);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 480);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.NightmarePickaxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 400);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TheBreaker);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 360);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CorruptYoyo);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 650);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.ShadowHelmet);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 1150);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.ShadowScalemail);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 900);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.ShadowGreaves);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 12);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CrimtaneOre);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 36);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CrimtaneBar);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 288);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Fleshcatcher);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 288);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TendonBow);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 360);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.BloodLustCluster);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 360);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.BloodButcherer);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 23);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TissueSample);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 570);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.DeathbringerPickaxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 475);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.FleshGrinder);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 432);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CrimsonYoyo);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 475);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.TheMeatball);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 770);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CrimsonHelmet);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 1360);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CrimsonScalemail);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 1065);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.CrimsonGreaves);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 20);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Bone);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 829);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.NecroHelmet);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 1236);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.NecroBreastplate);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk2Matter", 1032);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.NecroGreaves);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk3Matter", 10);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Hellstone);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk3Matter", 32);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.HellstoneBar);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk3Matter", 480);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.MoltenFury);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk3Matter", 640);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.FieryGreatsword);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk3Matter", 640);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.MoltenPickaxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk3Matter", 480);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.MoltenHamaxe);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk3Matter", 544);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.ImpStaff);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk3Matter", 320);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.MoltenHelmet);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk3Matter", 640);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.MoltenBreastplate);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk3Matter", 480);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.MoltenGreaves);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk3Matter", 500);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.DarkLance);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk3Matter", 500);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Flamelash);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk3Matter", 500);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.FlowerofFire);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk3Matter", 500);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.Sunfury);
          recipe.AddRecipe();

          recipe = new ModRecipe(mod);
          recipe.AddIngredient(null, "Mk3Matter", 500);
          recipe.AddTile(null, "AlchBench");
          recipe.SetResult(ItemID.HellwingBow);
          recipe.AddRecipe();
        }

    }
}
