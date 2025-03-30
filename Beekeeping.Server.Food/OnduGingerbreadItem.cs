using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace Beekeeping.Server.Food;

[Serialized]
[LocDisplayName("Gingerbread")]
[Weight(400)]
[Ecopedia("Food", "Baking", true, true, null)]
public class OnduGingerbreadItem : FoodItem
{
	public override LocString DisplayNamePlural => Localizer.DoStr("Gingerbread");

	public override LocString DisplayDescription => Localizer.DoStr("Tight and melting.");

	public override float Calories => 1200f;

	public override Nutrients Nutrition
	{
		get
		{
			Nutrients result = default(Nutrients);
			result.Carbs = 23f;
			result.Fat = 16f;
			result.Protein = 8f;
			result.Vitamins = 15f;
			return result;
		}
	}

	protected override float BaseShelfLife => (int)TimeUtil.HoursToSeconds(72.0);
}
