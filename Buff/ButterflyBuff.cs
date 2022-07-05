using MorePreHardmodeweapons.ModdedPlayer;
using Terraria;
using Terraria.ModLoader;

namespace MorePreHardmodeweapons.Buff
{
	public class ButterflyBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Butterfly's blessing");
			Description.SetDefault("The Butterfly's will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			SimpleModPlayer modPlayer = player.GetModPlayer<SimpleModPlayer>();
			if (player.ownedProjectileCounts[ModContent.ProjectileType<Items.Summon.ButterflySummon>()] > 0)
			{
				modPlayer.ButterflySummon = true;
			}
			if (!modPlayer.ButterflySummon)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
			{
				player.buffTime[buffIndex] = 18000;
			}
		}
	}
}