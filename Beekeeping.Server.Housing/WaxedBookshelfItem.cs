using System.Collections.Generic;
using Eco.Core.Items;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;

namespace Beekeeping.Server.Housing;

[Serialized]
[LocDisplayName("Waxed Bookshelf")]
[Ecopedia("Housing Objects", "Living Room", true, true, null)]
[Tag("Housing", 1)]
public class WaxedBookshelfItem : WorldObjectItem<WaxedBookshelfObject>
{
	public static readonly HomeFurnishingValue homeValue;

	public override LocString DisplayDescription => Localizer.DoStr("A place to store knowledge and information; leads to the town hall.");

	public override DirectionAxisFlags RequiresSurfaceOnSides { get; } = DirectionAxisFlags.Down;

	public override HomeFurnishingValue HomeValue => homeValue;

	static WaxedBookshelfItem()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		homeValue = new HomeFurnishingValue
		{
			Category = HousingConfig.GetRoomCategory("Living Room"),
			HouseValue = 2.5f,
			TypeForRoomLimit = Localizer.DoStr("Shelves"),
			DiminishingReturnPercent = 0.5f
		};
		WorldObject.AddOccupancy<WaxedHewnBenchObject>(new List<BlockOccupancy>
		{
			new BlockOccupancy(new Vector3i(0, 1, 0)),
			new BlockOccupancy(new Vector3i(0, 0, 0))
		});
	}
}
