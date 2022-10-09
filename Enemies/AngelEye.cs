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
    public class AngelEye : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.DemonEye];

            DisplayName.SetDefault("Angel Eye");
        }
        public override void SetDefaults()
        {
            NPC.width = 30;
            NPC.height = 32;
            NPC.damage = 16;
            NPC.defense = 2;
            NPC.lifeMax = 60;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.value = 75f;
            NPC.aiStyle = 2;
            NPC.knockBackResist = 0.8f;
            AIType = NPCID.DemonEye;
            AnimationType = NPCID.DemonEye;
            Banner = NPC.type;
            BannerItem = ModContent.ItemType<AngelEyeBanner>();
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
			return SpawnCondition.OverworldNightMonster.Chance;
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Times.NightTime,
                new FlavorTextBestiaryInfoElement("Said to be a 'brother' to demon eyes, however the townsfolk think otherwise.")
            });
        }

        public override void ModifyNPCLoot(NPCLoot npcLoot) {
        npcLoot.Add(ItemDropRule.Common(ItemID.Lens, 1));
        }
    }
}