using Terraria;
using Terraria.ModLoader;

namespace EatMoney.Buffs{
	public class PlentySatisfied : ModBuff{
		public override void SetDefaults(){
			DisplayName.SetDefault("Plenty Satisfied");
			Description.SetDefault("Medium improvements to all stats");
		}

		public override void Update(Player player, ref int buffIndex){
			player.statDefense += 3;
			player.magicCrit += 3;
			player.meleeCrit += 3;
			player.rangedCrit += 3;
			player.thrownCrit += 3;
			player.meleeSpeed += 0.075f;
			player.magicDamage += 0.075f;
			player.meleeDamage += 0.075f;
			player.rangedDamage += 0.075f;
			player.thrownDamage += 0.075f;
			player.minionDamage += 0.075f;
			player.moveSpeed += 3;
			player.lifeRegen += 1;
		}
	}
}