using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace Beekeeping.Server.Food;

[Serialized]
[LocDisplayName("Tajine")]
[Weight(450)]
[Ecopedia("Food", "Cooking", true, true, null)]
public class OnduTajineItem : FoodItem
{
	public override LocString DisplayNamePlural => Localizer.DoStr("Tajine");

	public override LocString DisplayDescription => Localizer.DoStr("Traditional Tagine.");

	public override float Calories => 1300f;

	public override Nutrients Nutrition
	{
		get
		{
			Nutrients result = default(Nutrients);
			result.Carbs = 11f;
			result.Fat = 19f;
			result.Protein = 20f;
			result.Vitamins = 12f;
			return result;
		}
	}

	protected override float BaseShelfLife => (int)TimeUtil.HoursToSeconds(72.0);
}
