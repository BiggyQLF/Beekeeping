using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace Beekeeping.Server.Food;

[Serialized]
[LocDisplayName("Honey Roast")]
[Weight(400)]
[Ecopedia("Food", "Cooking", true, true, null)]
public class OnduHoneyRoastItem : FoodItem
{
	public override LocString DisplayNamePlural => Localizer.DoStr("Honey Roast");

	public override LocString DisplayDescription => Localizer.DoStr("A melting meat thanks to its honey...");

	public override float Calories => 1150f;

	public override Nutrients Nutrition
	{
		get
		{
			Nutrients result = default(Nutrients);
			result.Carbs = 12f;
			result.Fat = 20f;
			result.Protein = 22f;
			result.Vitamins = 4f;
			return result;
		}
	}

	protected override float BaseShelfLife => (int)TimeUtil.HoursToSeconds(72.0);
}
