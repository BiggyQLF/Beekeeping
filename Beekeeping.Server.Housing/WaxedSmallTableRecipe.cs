using System;
using System.Collections.Generic;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

namespace Beekeeping.Server.Housing;

[RequiresSkill(typeof(CarpentrySkill), 7)]
[Ecopedia("Housing Objects", "Seating", false, true, "Waxed Small Table Item")]
public class WaxedSmallTableRecipe : RecipeFamily
{
	public WaxedSmallTableRecipe()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		((RecipeFamily)this).Recipes = new List<Recipe>
		{
			new Recipe("WaxedSmallTable", Localizer.DoStr("Waxed Small Table"), (IngredientElement[])(object)new IngredientElement[3]
			{
				new IngredientElement(typeof(LumberItem), 2f, false),
				new IngredientElement(typeof(NailItem), 3f, false),
				new IngredientElement(typeof(OnduWaxItem), 1f, false)
			}, (CraftingElement[])(object)new CraftingElement[1] { (CraftingElement)new CraftingElement<WaxedSmallTableItem>(1f) })
		};
		base.ExperienceOnCraft = 3f;
		((RecipeFamily)this).LaborInCalories = RecipeFamily.CreateLaborInCaloriesValue(100f, typeof(CarpentrySkill));
		((RecipeFamily)this).CraftMinutes = RecipeFamily.CreateCraftTimeValue(typeof(WaxedSmallTableRecipe), 1f, typeof(CarpentrySkill), new Type[2]
		{
			typeof(CarpentryFocusedSpeedTalent),
			typeof(CarpentryParallelSpeedTalent)
		});
		((RecipeFamily)this).Initialize(Localizer.DoStr("Waxed Small Table"), typeof(WaxedSmallTableRecipe));
		CraftingComponent.AddRecipe(typeof(SawmillObject), (RecipeFamily)(object)this);
	}
}
