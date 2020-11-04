using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EatMoney.Items{
	public class GoldCoinFood : ModItem{
		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Gold Coin Nuggets");
			Tooltip.SetDefault("Major improvements to all stats\n'GO BACK I want to be NUGGET'");
		}

		public override void SetDefaults(){
			item.width = 16;
			item.height = 16;
			item.maxStack = 30;
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.rare = 3;
			item.consumable = true;
			item.useStyle = 2;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useTurn = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldCoin, 10);
			recipe.AddTile(TileID.CookingPots);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public override bool CanUseItem(Player player){
			int buff = mod.BuffType("ExquisitelyStuffed");
			return !player.HasBuff(buff);
		}

		public override bool UseItem(Player player){
			if(player.HasBuff(BuffID.WellFed)) player.ClearBuff(BuffID.WellFed);
			if(player.HasBuff(mod.BuffType("PlentySatisfied"))) player.ClearBuff(mod.BuffType("PlentySatisfied"));
			if(player.HasBuff(mod.BuffType("BlissfullyIndulged"))) player.ClearBuff(mod.BuffType("BlissfullyIndulged"));
			player.AddBuff(mod.BuffType("ExquisitelyStuffed"), 28800);
			return true;
		}
	}
}