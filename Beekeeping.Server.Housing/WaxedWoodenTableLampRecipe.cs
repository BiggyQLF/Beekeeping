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
[Ecopedia("Housing Objects", "Lighting", false, true, "WoodenTableLamp Item")]
public class WaxedWoodenTableLampRecipe : RecipeFamily
{
	public WaxedWoodenTableLampRecipe()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		((RecipeFamily)this).Recipes = new List<Recipe>
		{
			new Recipe("WaxedWoodenTableLamp", Localizer.DoStr("Waxed Wooden Table Lamp"), (IngredientElement[])(object)new IngredientElement[2]
			{
				new IngredientElement(typeof(WoodenTableLampItem), 1f, false),
				new IngredientElement(typeof(OnduWaxItem), 2f, false)
			}, (CraftingElement[])(object)new CraftingElement[1] { (CraftingElement)new CraftingElement<WaxedWoodenTableLampItem>(1f) })
		};
		base.ExperienceOnCraft = 3f;
		((RecipeFamily)this).LaborInCalories = RecipeFamily.CreateLaborInCaloriesValue(200f, typeof(CarpentrySkill));
		((RecipeFamily)this).CraftMinutes = RecipeFamily.CreateCraftTimeValue(typeof(WaxedWoodenTableLampRecipe), 1f, typeof(CarpentrySkill), new Type[2]
		{
			typeof(CarpentryFocusedSpeedTalent),
			typeof(CarpentryParallelSpeedTalent)
		});
		((RecipeFamily)this).Initialize(Localizer.DoStr("Waxed Wooden Table Lamp"), typeof(WaxedWoodenTableLampRecipe));
		CraftingComponent.AddRecipe(typeof(SawmillObject), (RecipeFamily)(object)this);
	}
}
