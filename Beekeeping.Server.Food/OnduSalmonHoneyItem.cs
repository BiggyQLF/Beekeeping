using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace Beekeeping.Server.Food;

[Serialized]
[LocDisplayName("Salmon Honey")]
[Ecopedia("Food", "Cooking", true, true, null)]
[Weight(500)]
public class OnduSalmonHoneyItem : FoodItem
{
	public override LocString DisplayNamePlural => Localizer.DoStr("Salmon Honey");

	public override LocString DisplayDescription => Localizer.DoStr("Salmon with honey");

	public override float Calories => 1400f;

	public override Nutrients Nutrition
	{
		get
		{
			Nutrients result = default(Nutrients);
			result.Carbs = 9f;
			result.Fat = 25f;
			result.Protein = 8f;
			result.Vitamins = 20f;
			return result;
		}
	}

	protected override float BaseShelfLife => (int)TimeUtil.HoursToSeconds(72.0);
}
