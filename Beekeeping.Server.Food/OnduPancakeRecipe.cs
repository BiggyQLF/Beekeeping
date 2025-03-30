using System;
using System.Collections.Generic;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

namespace Beekeeping.Server.Food;

[RequiresSkill(typeof(BakingSkill), 5)]
[Ecopedia("Food", "Baking", false, true, "Pancake Item")]
public class OnduPancakeRecipe : RecipeFamily
{
	public OnduPancakeRecipe()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		Recipe val = new Recipe();
		val.Init("Pancake", Localizer.DoStr("Pancake"), new List<IngredientElement>
		{
			new IngredientElement(typeof(OnduPurifiedHoneyItem), 1f, typeof(BakingSkill), (Type)null),
			new IngredientElement(typeof(SugarItem), 2f, typeof(BakingSkill), (Type)null),
			new IngredientElement(typeof(FlourItem), 4f, typeof(BakingSkill), (Type)null),
			new IngredientElement("Fat", 4f, typeof(BakingSkill), (Type)null)
		}, new List<CraftingElement> { (CraftingElement)(object)new CraftingElement<OnduPancakeItem>(1f) });
		((RecipeFamily)this).Recipes = new List<Recipe> { val };
		base.ExperienceOnCraft = 1f;
		((RecipeFamily)this).LaborInCalories = RecipeFamily.CreateLaborInCaloriesValue(20f, typeof(BakingSkill));
		((RecipeFamily)this).CraftMinutes = RecipeFamily.CreateCraftTimeValue(typeof(OnduPancakeRecipe), 4f, typeof(BakingSkill), new Type[2]
		{
			typeof(BakingFocusedSpeedTalent),
			typeof(BakingParallelSpeedTalent)
		});
		((RecipeFamily)this).Initialize(Localizer.DoStr("Pancake"), typeof(OnduPancakeRecipe));
		CraftingComponent.AddRecipe(typeof(BakeryOvenObject), (RecipeFamily)(object)this);
	}
}
