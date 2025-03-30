using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace Beekeeping.Server.Food;

[Serialized]
[LocDisplayName("Fruit Cake")]
[Weight(450)]
[Ecopedia("Food", "Baking", true, true, null)]
public class OnduFruitCakeItem : FoodItem
{
	public override LocString DisplayNamePlural => Localizer.DoStr("Fruit Cake");

	public override LocString DisplayDescription => Localizer.DoStr("Happy Birthday!");

	public override float Calories => 1300f;

	public override Nutrients Nutrition
	{
		get
		{
			Nutrients result = default(Nutrients);
			result.Carbs = 17f;
			result.Fat = 5f;
			result.Protein = 11f;
			result.Vitamins = 29f;
			return result;
		}
	}

	protected override float BaseShelfLife => (int)TimeUtil.HoursToSeconds(72.0);
}
