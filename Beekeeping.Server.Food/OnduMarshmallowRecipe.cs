using System;
using System.Collections.Generic;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

namespace Beekeeping.Server.Food;

[RequiresSkill(typeof(CookingSkill), 3)]
[Ecopedia("Food", "Cooking", false, true, "Marshmallow Item")]
public class OnduMarshmallowRecipe : RecipeFamily
{
	public OnduMarshmallowRecipe()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		Recipe val = new Recipe();
		val.Init("Marshmallow", Localizer.DoStr("Marshmallow"), new List<IngredientElement>
		{
			new IngredientElement(typeof(OnduPurifiedHoneyItem), 1f, typeof(BakingSkill), (Type)null),
			new IngredientElement(typeof(SugarItem), 2f, typeof(BakingSkill), (Type)null),
			new IngredientElement(typeof(FlourItem), 1f, typeof(BakingSkill), (Type)null)
		}, new List<CraftingElement> { (CraftingElement)(object)new CraftingElement<OnduMarshmallowItem>(1f) });
		((RecipeFamily)this).Recipes = new List<Recipe> { val };
		base.ExperienceOnCraft = 1f;
		((RecipeFamily)this).LaborInCalories = RecipeFamily.CreateLaborInCaloriesValue(25f, typeof(CookingSkill));
		((RecipeFamily)this).CraftMinutes = RecipeFamily.CreateCraftTimeValue(typeof(OnduMarshmallowRecipe), 4f, typeof(CookingSkill), new Type[2]
		{
			typeof(CookingFocusedSpeedTalent),
			typeof(CookingParallelSpeedTalent)
		});
		((RecipeFamily)this).Initialize(Localizer.DoStr("Marshmallow"), typeof(OnduMarshmallowRecipe));
		CraftingComponent.AddRecipe(typeof(CastIronStoveObject), (RecipeFamily)(object)this);
	}
}
