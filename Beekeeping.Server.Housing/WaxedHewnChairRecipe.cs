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
[Ecopedia("Housing Objects", "Seating", false, true, "Waxed HewnChair Item")]
public class WaxedHewnChairRecipe : RecipeFamily
{
	public WaxedHewnChairRecipe()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		((RecipeFamily)this).Recipes = new List<Recipe>
		{
			new Recipe("WaxedHewnChair", Localizer.DoStr("Waxed Hewn Chair"), (IngredientElement[])(object)new IngredientElement[2]
			{
				new IngredientElement(typeof(HewnChairItem), 1f, false),
				new IngredientElement(typeof(OnduWaxItem), 1f, false)
			}, (CraftingElement[])(object)new CraftingElement[1] { (CraftingElement)new CraftingElement<WaxedHewnChairItem>(1f) })
		};
		((RecipeFamily)this).LaborInCalories = RecipeFamily.CreateLaborInCaloriesValue(100f, typeof(CarpentrySkill));
		((RecipeFamily)this).CraftMinutes = RecipeFamily.CreateCraftTimeValue(typeof(WaxedHewnChairRecipe), 3f, typeof(CarpentrySkill), new Type[2]
		{
			typeof(CarpentryFocusedSpeedTalent),
			typeof(CarpentryParallelSpeedTalent)
		});
		((RecipeFamily)this).Initialize(Localizer.DoStr("Waxed Hewn Chair"), typeof(WaxedHewnChairRecipe));
		CraftingComponent.AddRecipe(typeof(CarpentryTableObject), (RecipeFamily)(object)this);
	}
}
