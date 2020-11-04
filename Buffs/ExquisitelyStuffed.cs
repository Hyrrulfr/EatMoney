using Terraria;
using Terraria.ModLoader;

namespace EatMoney.Buffs{
	public class ExquisitelyStuffed : ModBuff{
		public override void SetDefaults(){
			DisplayName.SetDefault("Exquisitely Stuffed");
			Description.SetDefault("Major improvements to all stats");
		}

		public override void Update(Player player, ref int buffIndex){
			player.statDefense += 4;
			player.magicCrit += 4;
			player.meleeCrit += 4;
			player.rangedCrit += 4;
			player.thrownCrit += 4;
			player.meleeSpeed += 0.1f;
			player.magicDamage += 0.1f;
			player.meleeDamage += 0.1f;
			player.rangedDamage += 0.1f;
			player.thrownDamage += 0.1f;
			player.minionDamage += 0.1f;
			player.moveSpeed += 4;
			player.lifeRegen += 2;
		}
	}
}