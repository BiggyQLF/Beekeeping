using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace Beekeeping.Server.Food;

[Serialized]
[LocDisplayName("Blueberry Cocktail")]
[Weight(350)]
[Ecopedia("Food", "Cooking", true, true, null)]
public class OnduCocktailItem : FoodItem
{
	public override LocString DisplayNamePlural => Localizer.DoStr("Blueberry Cocktail");

	public override LocString DisplayDescription => Localizer.DoStr("For special occasions...");

	public override float Calories => 800f;

	public override Nutrients Nutrition
	{
		get
		{
			Nutrients result = default(Nutrients);
			result.Carbs = 19f;
			result.Fat = 6f;
			result.Protein = 8f;
			result.Vitamins = 29f;
			return result;
		}
	}

	protected override float BaseShelfLife => (int)TimeUtil.HoursToSeconds(72.0);
}
