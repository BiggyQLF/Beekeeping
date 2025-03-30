using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace Beekeeping.Server.Food;

[Serialized]
[LocDisplayName("Madeleine")]
[Weight(150)]
[Ecopedia("Food", "Baking", true, true, null)]
public class OnduMadeleineItem : FoodItem
{
	public override LocString DisplayNamePlural => Localizer.DoStr("Madeleine");

	public override LocString DisplayDescription => Localizer.DoStr("A Spanish and French pastry.");

	public override float Calories => 700f;

	public override Nutrients Nutrition
	{
		get
		{
			Nutrients result = default(Nutrients);
			result.Carbs = 18f;
			result.Fat = 7f;
			result.Protein = 13f;
			result.Vitamins = 7f;
			return result;
		}
	}

	protected override float BaseShelfLife => (int)TimeUtil.HoursToSeconds(72.0);
}
