using System;
using System.Collections.Generic;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

namespace Beekeeping.Server.Housing;

[RequiresSkill(typeof(CarpentrySkill), 4)]
[Ecopedia("Housing Objects", "Seating", false, true, "Waxed HewnTable Item")]
public class WaxedHewnTableRecipe : RecipeFamily
{
	public WaxedHewnTableRecipe()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		((RecipeFamily)this).Recipes = new List<Recipe>
		{
			new Recipe("WaxedHewnTable", Localizer.DoStr("Waxed Hewn Table"), (IngredientElement[])(object)new IngredientElement[2]
			{
				new IngredientElement(typeof(HewnTableItem), 1f, false),
				new IngredientElement(typeof(OnduWaxItem), 2f, false)
			}, (CraftingElement[])(object)new CraftingElement[1] { (CraftingElement)new CraftingElement<WaxedHewnTableItem>(1f) })
		};
		base.ExperienceOnCraft = 2f;
		((RecipeFamily)this).LaborInCalories = RecipeFamily.CreateLaborInCaloriesValue(100f, typeof(CarpentrySkill));
		((RecipeFamily)this).CraftMinutes = RecipeFamily.CreateCraftTimeValue(typeof(WaxedHewnTableRecipe), 4f, typeof(CarpentrySkill), new Type[2]
		{
			typeof(CarpentryFocusedSpeedTalent),
			typeof(CarpentryParallelSpeedTalent)
		});
		((RecipeFamily)this).Initialize(Localizer.DoStr("Waxed Hewn Table"), typeof(WaxedHewnTableRecipe));
		CraftingComponent.AddRecipe(typeof(CarpentryTableObject), (RecipeFamily)(object)this);
	}
}
