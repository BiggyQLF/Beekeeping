using System;
using System.Collections.Generic;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

namespace Beekeeping.Server.Food;

[RequiresSkill(typeof(CookingSkill), 3)]
[Ecopedia("Food", "Cooking", false, true, "SkewerMeatandHoney Item")]
public class OnduSkewerRecipe : RecipeFamily
{
	public OnduSkewerRecipe()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		Recipe val = new Recipe();
		val.Init("SkewerMeatandHoney", Localizer.DoStr("Skewer Meat and Honey"), new List<IngredientElement>
		{
			new IngredientElement(typeof(OnduPurifiedHoneyItem), 1f, typeof(CookingSkill), (Type)null),
			new IngredientElement(typeof(MeatStockItem), 1f, false),
			new IngredientElement(typeof(PreparedMeatItem), 2f, typeof(CookingSkill), (Type)null)
		}, new List<CraftingElement> { (CraftingElement)(object)new CraftingElement<OnduSkewerItem>(1f) });
		((RecipeFamily)this).Recipes = new List<Recipe> { val };
		base.ExperienceOnCraft = 1f;
		((RecipeFamily)this).LaborInCalories = RecipeFamily.CreateLaborInCaloriesValue(25f, typeof(CookingSkill));
		((RecipeFamily)this).CraftMinutes = RecipeFamily.CreateCraftTimeValue(typeof(OnduSkewerRecipe), 4f, typeof(CookingSkill), new Type[2]
		{
			typeof(BakingFocusedSpeedTalent),
			typeof(BakingParallelSpeedTalent)
		});
		((RecipeFamily)this).Initialize(Localizer.DoStr("Skewer Meat and Honey"), typeof(OnduSkewerRecipe));
		CraftingComponent.AddRecipe(typeof(CastIronStoveObject), (RecipeFamily)(object)this);
	}
}
