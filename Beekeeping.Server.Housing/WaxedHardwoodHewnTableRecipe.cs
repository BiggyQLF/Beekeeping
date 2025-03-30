using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

namespace Beekeeping.Server.Housing;

[RequiresSkill(typeof(CarpentrySkill), 4)]
[Ecopedia("Housing Objects", "Seating", false, true, "Waxed Hardwood HewnTable Item")]
public class WaxedHardwoodHewnTableRecipe : Recipe
{
	public WaxedHardwoodHewnTableRecipe()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		CraftingComponent.AddTagProduct(typeof(SawmillObject), typeof(WaxedHewnTableRecipe), new Recipe("Waxed Hewn Table", Localizer.DoStr("Waxed Hewn Table"), (IngredientElement[])(object)new IngredientElement[2]
		{
			new IngredientElement(typeof(HewnHardwoodTableItem), 1f, false),
			new IngredientElement(typeof(OnduWaxItem), 2f, false)
		}, (CraftingElement[])(object)new CraftingElement[1] { (CraftingElement)new CraftingElement<WaxedHewnTableItem>(1f) }));
	}
}
