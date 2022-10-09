using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using JackspajfsRandomStuff2.Banners.Tiles;
using Terraria.GameContent.Creative;

namespace JackspajfsRandomStuff2.Banners
{
    public class BlackHoleEyeBanner : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<BlackHoleEyeBannerTile>(), 0);
            Item.width = 12;
            Item.height = 28;
            Item.maxStack = 9999;
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.buyPrice(0, 0, 10, 0);
        }
    }
}