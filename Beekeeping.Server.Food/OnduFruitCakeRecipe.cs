using System;
using System.Collections.Generic;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

namespace Beekeeping.Server.Food;

[RequiresSkill(typeof(AdvancedBakingSkill), 6)]
[Ecopedia("Food", "Baking", false, true, "FruitCake Item")]
public class OnduFruitCakeRecipe : RecipeFamily
{
	public OnduFruitCakeRecipe()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		Recipe val = new Recipe();
		val.Init("FruitCake", Localizer.DoStr("Fruit Cake"), new List<IngredientElement>
		{
			new IngredientElement(typeof(OnduPurifiedHoneyItem), 1f, typeof(AdvancedBakingSkill), (Type)null),
			new IngredientElement("Fat", 4f, typeof(AdvancedBakingSkill), (Type)null),
			new IngredientElement("Fruit", 12f, typeof(AdvancedBakingSkill), (Type)null),
			new IngredientElement(typeof(HuckleberryExtractItem), 2f, typeof(AdvancedBakingSkill), (Type)null),
			new IngredientElement(typeof(FlourItem), 4f, typeof(AdvancedBakingSkill), (Type)null),
			new IngredientElement(typeof(YeastItem), 2f, typeof(AdvancedBakingSkill), (Type)null)
		}, new List<CraftingElement> { (CraftingElement)(object)new CraftingElement<OnduFruitCakeItem>(1f) });
		((RecipeFamily)this).Recipes = new List<Recipe> { val };
		base.ExperienceOnCraft = 1f;
		((RecipeFamily)this).LaborInCalories = RecipeFamily.CreateLaborInCaloriesValue(45f, typeof(AdvancedBakingSkill));
		((RecipeFamily)this).CraftMinutes = RecipeFamily.CreateCraftTimeValue(typeof(OnduFruitCakeRecipe), 20f, typeof(AdvancedBakingSkill), new Type[2]
		{
			typeof(AdvancedBakingFocusedSpeedTalent),
			typeof(AdvancedBakingParallelSpeedTalent)
		});
		((RecipeFamily)this).Initialize(Localizer.DoStr("Fruit Cake"), typeof(OnduFruitCakeRecipe));
		CraftingComponent.AddRecipe(typeof(BakeryOvenObject), (RecipeFamily)(object)this);
	}
}
