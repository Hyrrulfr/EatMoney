using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EatMoney.Items{
	public class PlatinumCoinFood : ModItem{
		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Platinum Coin Cookie");
			Tooltip.SetDefault("Maximal improvements to all stats\nNot to be confused with Platinum Cookies");
		}

		public override void SetDefaults(){
			item.width = 16;
			item.height = 16;
			item.maxStack = 30;
			item.value = Item.buyPrice(2, 0, 0, 0);
			item.rare = 5;
			item.consumable = true;
			item.useStyle = 2;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useTurn = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumCoin, 2);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public override bool CanUseItem(Player player){
			int buff = mod.BuffType("BlissfullyIndulged");
			return !player.HasBuff(buff);
		}

		public override bool UseItem(Player player){
			if(player.HasBuff(BuffID.WellFed)) player.ClearBuff(BuffID.WellFed);
			if(player.HasBuff(mod.BuffType("PlentySatisfied"))) player.ClearBuff(mod.BuffType("PlentySatisfied"));
			if(player.HasBuff(mod.BuffType("ExquisitelyStuffed"))) player.ClearBuff(mod.BuffType("ExquisitelyStuffed"));
			player.AddBuff(mod.BuffType("BlissfullyIndulged"), 28800);
			return true;
		}
	}
}