using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EatMoney.Items{
	public class SilverCoinFood : ModItem{
		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Skewered Silver Coins");
			Tooltip.SetDefault("Medium improvements to all stats\n'You're blue now.'");
		}

		public override void SetDefaults(){
			item.width = 16;
			item.height = 16;
			item.maxStack = 30;
			item.value = Item.buyPrice(0, 0, 20, 0);
			item.rare = 2;
			item.consumable = true;
			item.useStyle = 2;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useTurn = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverCoin, 20);
			recipe.AddTile(TileID.CookingPots);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public override bool CanUseItem(Player player){
			int buff = mod.BuffType("PlentySatisfied");
			return !player.HasBuff(buff);
		}

		public override bool UseItem(Player player){
			if(player.HasBuff(BuffID.WellFed)) player.ClearBuff(BuffID.WellFed);
			if(player.HasBuff(mod.BuffType("ExquisitelyStuffed"))) player.ClearBuff(mod.BuffType("ExquisitelyStuffed"));
			if(player.HasBuff(mod.BuffType("BlissfullyIndulged"))) player.ClearBuff(mod.BuffType("BlissfullyIndulged"));
			player.AddBuff(mod.BuffType("PlentySatisfied"), 28800);
			return true;
		}
	}
}