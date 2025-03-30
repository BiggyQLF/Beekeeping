using System;
using System.Collections.Generic;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

namespace Beekeeping.Server.Food;

[RequiresSkill(typeof(AdvancedCookingSkill), 6)]
[Ecopedia("Food", "Cooking", false, true, "Tajine Item")]
public class OnduTajineRecipe : RecipeFamily
{
	public OnduTajineRecipe()
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
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		Recipe val = new Recipe();
		val.Init("Tajine", Localizer.DoStr("Tajine"), new List<IngredientElement>
		{
			new IngredientElement(typeof(OnduPurifiedHoneyItem), 2f, typeof(AdvancedCookingSkill), (Type)null),
			new IngredientElement(typeof(InfusedOilItem), 2f, typeof(AdvancedCookingSkill), (Type)null),
			new IngredientElement(typeof(SimmeredMeatItem), 2f, typeof(AdvancedCookingSkill), (Type)null),
			new IngredientElement(typeof(CornmealItem), 2f, typeof(AdvancedCookingSkill), (Type)null),
			new IngredientElement(typeof(VegetableMedleyItem), 2f, typeof(AdvancedCookingSkill), (Type)null),
			new IngredientElement(typeof(BoiledRiceItem), 1f, typeof(AdvancedCookingSkill), (Type)null)
		}, new List<CraftingElement> { (CraftingElement)(object)new CraftingElement<OnduTajineItem>(1f) });
		((RecipeFamily)this).Recipes = new List<Recipe> { val };
		base.ExperienceOnCraft = 1f;
		((RecipeFamily)this).LaborInCalories = RecipeFamily.CreateLaborInCaloriesValue(20f, typeof(AdvancedCookingSkill));
		((RecipeFamily)this).CraftMinutes = RecipeFamily.CreateCraftTimeValue(typeof(OnduTajineRecipe), 4f, typeof(AdvancedCookingSkill), new Type[2]
		{
			typeof(AdvancedCookingFocusedSpeedTalent),
			typeof(AdvancedCookingParallelSpeedTalent)
		});
		((RecipeFamily)this).Initialize(Localizer.DoStr("Tajine"), typeof(OnduTajineRecipe));
		CraftingComponent.AddRecipe(typeof(StoveObject), (RecipeFamily)(object)this);
	}
}
