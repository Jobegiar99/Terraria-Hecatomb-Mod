
using Terraria;
using Terraria.ModLoader;

namespace HecatombMod.Buffs
{
    public class TomeofEarthArmorBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Earth Armor");
            Description.SetDefault("Increased defense and endurance.");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false; //Add this so the nurse doesn't remove the buff when healing
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 5; //Grant a +4 defense boost to the player while the buff is active.
            player.endurance += 5;
        }
    }
}