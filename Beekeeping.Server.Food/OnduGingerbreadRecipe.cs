using System;
using System.Collections.Generic;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

namespace Beekeeping.Server.Food;

[RequiresSkill(typeof(AdvancedBakingSkill), 5)]
[Ecopedia("Food", "Baking", false, true, "Gingerbread Item")]
public class OnduGingerbreadRecipe : RecipeFamily
{
	public OnduGingerbreadRecipe()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		Recipe val = new Recipe();
		val.Init("Gingerbread", Localizer.DoStr("Gingerbread"), new List<IngredientElement>
		{
			new IngredientElement(typeof(OnduPurifiedHoneyItem), 1f, typeof(AdvancedBakingSkill), (Type)null),
			new IngredientElement("Fat", 2f, typeof(AdvancedBakingSkill), (Type)null),
			new IngredientElement(typeof(SimpleSyrupItem), 4f, typeof(AdvancedBakingSkill), (Type)null),
			new IngredientElement(typeof(YeastItem), 2f, typeof(AdvancedBakingSkill), (Type)null),
			new IngredientElement(typeof(FlourItem), 6f, typeof(AdvancedBakingSkill), (Type)null)
		}, new List<CraftingElement> { (CraftingElement)(object)new CraftingElement<OnduGingerbreadItem>(1f) });
		((RecipeFamily)this).Recipes = new List<Recipe> { val };
		base.ExperienceOnCraft = 1f;
		((RecipeFamily)this).LaborInCalories = RecipeFamily.CreateLaborInCaloriesValue(45f, typeof(AdvancedBakingSkill));
		((RecipeFamily)this).CraftMinutes = RecipeFamily.CreateCraftTimeValue(typeof(OnduGingerbreadRecipe), 3f, typeof(AdvancedBakingSkill), new Type[2]
		{
			typeof(AdvancedBakingFocusedSpeedTalent),
			typeof(AdvancedBakingParallelSpeedTalent)
		});
		((RecipeFamily)this).Initialize(Localizer.DoStr("Blueberry Cocktail"), typeof(OnduGingerbreadRecipe));
		CraftingComponent.AddRecipe(typeof(BakeryOvenObject), (RecipeFamily)(object)this);
	}
}
