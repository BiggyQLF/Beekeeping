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
[LocDisplayName("Waxed Hewn Bench")]
[Ecopedia("Housing Objects", "Seating", true, true, null)]
[Tag("Housing", 1)]
public class WaxedHewnBenchItem : WorldObjectItem<WaxedHewnBenchObject>
{
	public static readonly HomeFurnishingValue homeValue;

	public override LocString DisplayDescription => Localizer.DoStr("A waxed basic wooden bench.");

	public override DirectionAxisFlags RequiresSurfaceOnSides { get; } = DirectionAxisFlags.Down;

	public override HomeFurnishingValue HomeValue => homeValue;

	static WaxedHewnBenchItem()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		homeValue = new HomeFurnishingValue
		{
			Category = HousingConfig.GetRoomCategory("Seating"),
			HouseValue = 1.5f,
			TypeForRoomLimit = Localizer.DoStr("Chair"),
			DiminishingReturnPercent = 0.5f
		};
		WorldObject.AddOccupancy<WaxedHewnBenchObject>(new List<BlockOccupancy>
		{
			new BlockOccupancy(new Vector3i(-1, 0, 0)),
			new BlockOccupancy(new Vector3i(0, 0, 0))
		});
	}
}
