using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace Beekeeping.Server.Food;

[Serialized]
[LocDisplayName("Pancake")]
[Weight(200)]
[Ecopedia("Food", "Baking", true, true, null)]
public class OnduPancakeItem : FoodItem
{
	public override LocString DisplayNamePlural => Localizer.DoStr("Pancake");

	public override LocString DisplayDescription => Localizer.DoStr("Breakfast only.");

	public override float Calories => 900f;

	public override Nutrients Nutrition
	{
		get
		{
			Nutrients result = default(Nutrients);
			result.Carbs = 20f;
			result.Fat = 8f;
			result.Protein = 15f;
			result.Vitamins = 4f;
			return result;
		}
	}

	protected override float BaseShelfLife => (int)TimeUtil.HoursToSeconds(72.0);
}
