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
[LocDisplayName("Waxed Wooden Straw Bed")]
[Ecopedia("Housing Objects", "Bedroom", true, true, null)]
[Tag("Housing", 1)]
public class WaxedWoodenStrawBedItem : WorldObjectItem<WaxedWoodenStrawBedObject>
{
	public static readonly HomeFurnishingValue homeValue;

	public override LocString DisplayDescription => Localizer.DoStr("A nice, scratchy, waxed and horrible uncomfortable bed. But at least it keeps you off the ground.");

	public override DirectionAxisFlags RequiresSurfaceOnSides { get; } = DirectionAxisFlags.Down;

	public override HomeFurnishingValue HomeValue => homeValue;

	static WaxedWoodenStrawBedItem()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		homeValue = new HomeFurnishingValue
		{
			Category = HousingConfig.GetRoomCategory("Bedroom"),
			HouseValue = 4f,
			TypeForRoomLimit = Localizer.DoStr("Bed"),
			DiminishingReturnPercent = 0.3f
		};
		WorldObject.AddOccupancy<WaxedWoodenStrawBedObject>(new List<BlockOccupancy>
		{
			new BlockOccupancy(new Vector3i(0, 0, 0)),
			new BlockOccupancy(new Vector3i(0, 0, -1)),
			new BlockOccupancy(new Vector3i(0, 0, -2))
		});
	}
}
