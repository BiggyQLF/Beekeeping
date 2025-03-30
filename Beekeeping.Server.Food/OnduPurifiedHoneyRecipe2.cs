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
[Ecopedia("Food", "BeeKeeping", false, true, "PurifiedHoney2 Item")]
public class OnduPurifiedHoneyRecipe2 : RecipeFamily
{
	public OnduPurifiedHoneyRecipe2()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		Recipe val = new Recipe();
		val.Init("PurifiedHoney", Localizer.DoStr("Purified Honey"), new List<IngredientElement>
		{
			new IngredientElement(typeof(OnduFullPotItem), 1f, typeof(BeekeepingSkill), (Type)null)
		}, new List<CraftingElement>
		{
			(CraftingElement)(object)new CraftingElement<OnduPurifiedHoneyItem>(2f),
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
		((RecipeFamily)this).Initialize(Localizer.DoStr("Purified Honey"), typeof(OnduPurifiedHoneyRecipe2));
		CraftingComponent.AddRecipe(typeof(OnduHoneyExtractMecanicalObject), (RecipeFamily)(object)this);
	}
}
