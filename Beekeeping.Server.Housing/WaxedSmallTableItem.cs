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
[LocDisplayName("Waxed Small Table")]
[Ecopedia("Housing Objects", "Seating", true, true, null)]
public class WaxedSmallTableItem : WorldObjectItem<WaxedSmallTableObject>
{
	public static readonly HomeFurnishingValue homeValue;

	public override LocString DisplayDescription => Localizer.DoStr("More of a nightstand than a table, really.");

	public override DirectionAxisFlags RequiresSurfaceOnSides { get; } = DirectionAxisFlags.Down;

	public override HomeFurnishingValue HomeValue => homeValue;

	static WaxedSmallTableItem()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		homeValue = new HomeFurnishingValue
		{
			Category = HousingConfig.GetRoomCategory("Seating"),
			HouseValue = 1f,
			TypeForRoomLimit = Localizer.DoStr("Table"),
			DiminishingReturnPercent = 0.6f
		};
		WorldObject.AddOccupancy<WaxedHewnChairObject>(new List<BlockOccupancy>
		{
			new BlockOccupancy(new Vector3i(0, 0, 0))
		});
	}
}
