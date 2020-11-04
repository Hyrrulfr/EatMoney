using Terraria;
using Terraria.ModLoader;

namespace EatMoney.Buffs{
	public class BlissfullyIndulged : ModBuff{
		public override void SetDefaults(){
			DisplayName.SetDefault("Blissfully Indulged");
			Description.SetDefault("Maximal improvements to all stats");
		}

		public override void Update(Player player, ref int buffIndex){
			player.statDefense += 5;
			player.magicCrit += 5;
			player.meleeCrit += 5;
			player.rangedCrit += 5;
			player.thrownCrit += 5;
			player.meleeSpeed += 0.125f;
			player.magicDamage += 0.125f;
			player.meleeDamage += 0.125f;
			player.rangedDamage += 0.125f;
			player.thrownDamage += 0.125f;
			player.minionDamage += 0.125f;
			player.moveSpeed += 5;
			player.lifeRegen += 3;
			player.endurance += 0.05f;
		}
	}
}