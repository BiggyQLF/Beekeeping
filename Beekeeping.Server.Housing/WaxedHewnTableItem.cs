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
[LocDisplayName("Waxed Hewn Table")]
[Ecopedia("Housing Objects", "Seating", true, true, null)]
[Tag("Housing", 1)]
public class WaxedHewnTableItem : WorldObjectItem<WaxedHewnTableObject>
{
	public static readonly HomeFurnishingValue homeValue;

	public override LocString DisplayDescription => Localizer.DoStr("A large waxed table for placing things on.");

	public override DirectionAxisFlags RequiresSurfaceOnSides { get; } = DirectionAxisFlags.Down;

	public override HomeFurnishingValue HomeValue => homeValue;

	static WaxedHewnTableItem()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		homeValue = new HomeFurnishingValue
		{
			Category = HousingConfig.GetRoomCategory("Seating"),
			HouseValue = 1.5f,
			TypeForRoomLimit = Localizer.DoStr("Table"),
			DiminishingReturnPercent = 0.6f
		};
		WorldObject.AddOccupancy<WaxedHewnTableObject>(new List<BlockOccupancy>
		{
			new BlockOccupancy(new Vector3i(-1, 0, 0)),
			new BlockOccupancy(new Vector3i(0, 0, 0))
		});
	}
}
