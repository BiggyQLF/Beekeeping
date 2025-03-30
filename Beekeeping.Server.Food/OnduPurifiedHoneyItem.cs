using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace Beekeeping.Server.Food;

[Serialized]
[LocDisplayName("Purified honey")]
[Weight(100)]
[Ecopedia("Food", "BeeKeeping", true, true, null)]
public class OnduPurifiedHoneyItem : FoodItem
{
	public override LocString DisplayNamePlural => Localizer.DoStr("Purified honey");

	public override LocString DisplayDescription => Localizer.DoStr("Concentrated honey, ready-to-eat.");

	public override float Calories => 350f;

	public override Nutrients Nutrition
	{
		get
		{
			Nutrients result = default(Nutrients);
			result.Carbs = 9f;
			result.Fat = 0f;
			result.Protein = 0f;
			result.Vitamins = 3f;
			return result;
		}
	}

	protected override float BaseShelfLife => (int)TimeUtil.HoursToSeconds(99999.0);
}
