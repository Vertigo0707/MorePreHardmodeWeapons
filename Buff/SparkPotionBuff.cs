using Terraria;
using Terraria.ModLoader;

namespace MorePreHardmodeweapons.Buff
{
	public class SparkPotionBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Spark Potion is Active");
			Description.SetDefault("Increases defense, speed, and regen");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
		public override void Update(Player player, ref int buffIndex)
		{
			player.lifeRegen += 4;
			player.statDefense += 4;
			player.accRunSpeed += 0.9f;
		}
	}
}