using System;
using System.Collections.Generic;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

namespace Beekeeping.Server.Food;

[RequiresSkill(typeof(AdvancedCookingSkill), 4)]
[Ecopedia("Food", "Cooking", false, true, "HoneyRoast Item")]
public class OnduHoneyRoastRecipe : RecipeFamily
{
	public OnduHoneyRoastRecipe()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		Recipe val = new Recipe();
		val.Init("HoneyRoast", Localizer.DoStr("Honey Roast"), new List<IngredientElement>
		{
			new IngredientElement(typeof(OnduPurifiedHoneyItem), 1f, typeof(AdvancedCookingSkill), (Type)null),
			new IngredientElement(typeof(BakedRoastItem), 1f, typeof(AdvancedCookingSkill), (Type)null),
			new IngredientElement(typeof(MeatStockItem), 1f, typeof(AdvancedCookingSkill), (Type)null),
			new IngredientElement(typeof(SimpleSyrupItem), 1f, typeof(AdvancedCookingSkill), (Type)null),
			new IngredientElement("Fat", 1f, typeof(AdvancedCookingSkill), (Type)null)
		}, new List<CraftingElement> { (CraftingElement)(object)new CraftingElement<OnduHoneyRoastItem>(1f) });
		((RecipeFamily)this).Recipes = new List<Recipe> { val };
		base.ExperienceOnCraft = 1f;
		((RecipeFamily)this).LaborInCalories = RecipeFamily.CreateLaborInCaloriesValue(45f, typeof(AdvancedCookingSkill));
		((RecipeFamily)this).CraftMinutes = RecipeFamily.CreateCraftTimeValue(typeof(OnduHoneyRoastRecipe), 4f, typeof(AdvancedCookingSkill), new Type[2]
		{
			typeof(AdvancedCookingFocusedSpeedTalent),
			typeof(AdvancedCookingParallelSpeedTalent)
		});
		((RecipeFamily)this).Initialize(Localizer.DoStr("Honey Roast"), typeof(OnduHoneyRoastRecipe));
		CraftingComponent.AddRecipe(typeof(StoveObject), (RecipeFamily)(object)this);
	}
}
