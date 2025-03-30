using System;
using System.Collections.Generic;
using Beekeeping.Server.Benefit;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;

namespace Beekeeping.Server.Module;

[RequiresSkill(typeof(BeekeepingSkill), 1)]
public class OnduModernQueenBeeRecipe : RecipeFamily
{
	public OnduModernQueenBeeRecipe()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		((RecipeFamily)this).Recipes = new List<Recipe>
		{
			new Recipe("ModernQueenBee", Localizer.DoStr("Modern Queen Bee"), (IngredientElement[])(object)new IngredientElement[2]
			{
				new IngredientElement(typeof(OnduAdvancedQueenBeeItem), 1f, false),
				new IngredientElement(typeof(OnduRoyalJellyItem), 1f, false)
			}, (CraftingElement[])(object)new CraftingElement[1] { (CraftingElement)new CraftingElement<OnduModernQueenBeeItem>(1f) })
		};
		base.ExperienceOnCraft = 0.5f;
		((RecipeFamily)this).LaborInCalories = RecipeFamily.CreateLaborInCaloriesValue(150f, typeof(BeekeepingSkill));
		((RecipeFamily)this).CraftMinutes = RecipeFamily.CreateCraftTimeValue(typeof(OnduModernQueenBeeRecipe), 60f, typeof(BeekeepingSkill), new Type[2]
		{
			typeof(BeekeepingFocusedSpeedTalent),
			typeof(BeekeepingParallelSpeedTalent)
		});
		((RecipeFamily)this).Initialize(Localizer.DoStr("Modern Queen Bee"), typeof(OnduModernQueenBeeRecipe));
		CraftingComponent.AddRecipe(typeof(OnduSmallHiveObject), (RecipeFamily)(object)this);
	}
}
