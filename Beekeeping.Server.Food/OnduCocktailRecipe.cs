using System;
using System.Collections.Generic;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

namespace Beekeeping.Server.Food;

[RequiresSkill(typeof(AdvancedCookingSkill), 4)]
[Ecopedia("Food", "Cooking", false, true, "BlueberryCocktail Item")]
public class OnduCocktailRecipe : RecipeFamily
{
	public OnduCocktailRecipe()
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
		Recipe val = new Recipe();
		val.Init("BlueberryCocktail", Localizer.DoStr("Blueberry Cocktail"), new List<IngredientElement>
		{
			new IngredientElement(typeof(OnduPurifiedHoneyItem), 1f, typeof(AdvancedCookingSkill), (Type)null),
			new IngredientElement(typeof(SugarItem), 4f, typeof(AdvancedCookingSkill), (Type)null),
			new IngredientElement(typeof(YeastItem), 2f, typeof(AdvancedCookingSkill), (Type)null),
			new IngredientElement(typeof(HuckleberryExtractItem), 3f, typeof(AdvancedCookingSkill), (Type)null)
		}, new List<CraftingElement> { (CraftingElement)(object)new CraftingElement<OnduCocktailItem>(1f) });
		((RecipeFamily)this).Recipes = new List<Recipe> { val };
		base.ExperienceOnCraft = 1f;
		((RecipeFamily)this).LaborInCalories = RecipeFamily.CreateLaborInCaloriesValue(45f, typeof(AdvancedCookingSkill));
		((RecipeFamily)this).CraftMinutes = RecipeFamily.CreateCraftTimeValue(typeof(OnduCocktailRecipe), 4f, typeof(AdvancedCookingSkill), new Type[2]
		{
			typeof(AdvancedCookingFocusedSpeedTalent),
			typeof(AdvancedCookingParallelSpeedTalent)
		});
		((RecipeFamily)this).Initialize(Localizer.DoStr("Blueberry Cocktail"), typeof(OnduCocktailRecipe));
		CraftingComponent.AddRecipe(typeof(KitchenObject), (RecipeFamily)(object)this);
	}
}
