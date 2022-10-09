using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Bestiary;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using JackspajfsRandomStuff2.Banners;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader.Utilities;

namespace JackspajfsRandomStuff2.Enemies
{
    public class BlackHoleEye : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.DemonEye];

            DisplayName.SetDefault("Black Hole Eye");
        }
        public override void SetDefaults()
        {
            NPC.width = 30;
            NPC.height = 32;
            NPC.damage = 20;
            NPC.defense = 4;
            NPC.lifeMax = 80;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.value = 75f;
            NPC.aiStyle = 2;
            NPC.knockBackResist = 0.8f;
            AIType = NPCID.DemonEye;
            AnimationType = NPCID.DemonEye;
            Banner = NPC.type;
            BannerItem = ModContent.ItemType<BlackHoleEyeBanner>();
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (!Main.dayTime)
                return SpawnCondition.Sky.Chance;
            return 0;
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Sky,
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Times.NightTime,
                new FlavorTextBestiaryInfoElement("A demon eye that has seemed to evolve to space, and thrives of the stars.")
            });
        }

        //public override void ModifyNPCLoot(NPCLoot npcLoot)
        //{
            //npcLoot.Add(ItemDropRule.Common(ItemID.Lens, 1));
        //}
    }
}