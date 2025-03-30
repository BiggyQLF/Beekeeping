using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace Beekeeping.Server.Food;

[Serialized]
[LocDisplayName("Skewer meat and honey")]
[Ecopedia("Food", "Cooking", true, true, null)]
[Weight(200)]
public class OnduSkewerItem : FoodItem
{
	public override LocString DisplayNamePlural => Localizer.DoStr("Skewer meat and honey");

	public override LocString DisplayDescription => Localizer.DoStr("Skewer of meat with honey.");

	public override float Calories => 1050f;

	public override Nutrients Nutrition
	{
		get
		{
			Nutrients result = default(Nutrients);
			result.Carbs = 14f;
			result.Fat = 19f;
			result.Protein = 9f;
			result.Vitamins = 4f;
			return result;
		}
	}

	protected override float BaseShelfLife => (int)TimeUtil.HoursToSeconds(72.0);
}
