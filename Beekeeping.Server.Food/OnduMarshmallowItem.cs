using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace Beekeeping.Server.Food;

[Serialized]
[LocDisplayName("Marshmallow")]
[Weight(100)]
[Ecopedia("Food", "Cooking", true, true, null)]
public class OnduMarshmallowItem : FoodItem
{
	public override LocString DisplayNamePlural => Localizer.DoStr("Marshmallow");

	public override LocString DisplayDescription => Localizer.DoStr("The best food to share around a wood fire.");

	public override float Calories => 950f;

	public override Nutrients Nutrition
	{
		get
		{
			Nutrients result = default(Nutrients);
			result.Carbs = 18f;
			result.Fat = 7f;
			result.Protein = 4f;
			result.Vitamins = 15f;
			return result;
		}
	}

	protected override float BaseShelfLife => (int)TimeUtil.HoursToSeconds(72.0);
}
