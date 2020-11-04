using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EatMoney.Items{
	public class CopperCoinFood : ModItem{
		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Bag of Copper Coins");
			Tooltip.SetDefault("Minor improvements to all stats\nCrispy!");
		}

		public override void SetDefaults(){
			item.width = 16;
			item.height = 16;
			item.maxStack = 30;
			item.value = Item.buyPrice(0, 0, 0, 50);
			item.rare = 1;
			item.consumable = true;
			item.useStyle = 2;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useTurn = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperCoin, 50);
			recipe.AddTile(TileID.CookingPots);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public override bool CanUseItem(Player player){
			int buff = BuffID.WellFed;
			return !player.HasBuff(buff);
		}

		public override bool UseItem(Player player){
			if(player.HasBuff(mod.BuffType("PlentySatisfied"))) player.ClearBuff(mod.BuffType("PlentySatisfied"));
			if(player.HasBuff(mod.BuffType("ExquisitelyStuffed"))) player.ClearBuff(mod.BuffType("ExquisitelyStuffed"));
			if(player.HasBuff(mod.BuffType("BlissfullyIndulged"))) player.ClearBuff(mod.BuffType("BlissfullyIndulged"));
			player.AddBuff(BuffID.WellFed, 28800);
			return true;
		}
	}
}