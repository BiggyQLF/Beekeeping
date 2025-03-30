using System;
using System.Collections.Generic;
using Beekeeping.Server.Benefit;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;

namespace Beekeeping.Server.Food;

[RequiresSkill(typeof(BeekeepingSkill), 1)]
[Ecopedia("Food", "BeeKeeping", false, true, "PurifiedHoney Item")]
public class OnduPurifiedHoneyRecipe : RecipeFamily
{
	public OnduPurifiedHoneyRecipe()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		Recipe val = new Recipe();
		val.Init("PurifiedHoney", Localizer.DoStr("Purified Honey"), new List<IngredientElement>
		{
			new IngredientElement(typeof(OnduFullPotItem), 1f, true)
		}, new List<CraftingElement>
		{
			(CraftingElement)(object)new CraftingElement<OnduPurifiedHoneyItem>(1f),
			(CraftingElement)(object)new CraftingElement<OnduEmptyPotItem>(1f)
		});
		((RecipeFamily)this).Recipes = new List<Recipe> { val };
		base.ExperienceOnCraft = 1f;
		((RecipeFamily)this).LaborInCalories = RecipeFamily.CreateLaborInCaloriesValue(20f, typeof(BeekeepingSkill));
		((RecipeFamily)this).CraftMinutes = RecipeFamily.CreateCraftTimeValue(typeof(OnduPurifiedHoneyRecipe), 5f, typeof(BeekeepingSkill), new Type[2]
		{
			typeof(BeekeepingFocusedSpeedTalent),
			typeof(BeekeepingParallelSpeedTalent)
		});
		((RecipeFamily)this).Initialize(Localizer.DoStr("Purified Honey"), typeof(OnduPurifiedHoneyRecipe));
		CraftingComponent.AddRecipe(typeof(OnduHoneyExtractObject), (RecipeFamily)(object)this);
	}
}
