using System;
using System.Collections.Generic;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

namespace Beekeeping.Server;

[RequiresSkill(typeof(TailoringSkill), 1)]
public class BeekeeperHatRecipe : RecipeFamily
{
	public BeekeeperHatRecipe()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		((RecipeFamily)this).Recipes = new List<Recipe>
		{
			new Recipe("BeekeeperHat", Localizer.DoStr("Beekeeper Hat"), (IngredientElement[])(object)new IngredientElement[2]
			{
				new IngredientElement(typeof(LeatherHideItem), 2f, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),
				new IngredientElement(typeof(ClothItem), 2f, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent))
			}, (CraftingElement[])(object)new CraftingElement[1] { (CraftingElement)new CraftingElement<OnduBeekeeperHatItem>(1f) })
		};
		((RecipeFamily)this).LaborInCalories = RecipeFamily.CreateLaborInCaloriesValue(60f, typeof(TailoringSkill));
		((RecipeFamily)this).CraftMinutes = RecipeFamily.CreateCraftTimeValue(typeof(BeekeeperHatRecipe), 10f, typeof(TailoringSkill), new Type[2]
		{
			typeof(TailoringFocusedSpeedTalent),
			typeof(TailoringParallelSpeedTalent)
		});
		((RecipeFamily)this).Initialize(Localizer.DoStr("Beekeeper Hat"), typeof(BeekeeperHatRecipe));
		CraftingComponent.AddRecipe(typeof(TailoringTableObject), (RecipeFamily)(object)this);
	}
}
