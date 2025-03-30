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
[LocDisplayName("Waxed WoodenFabricBed")]
[Ecopedia("Housing Objects", "Bedroom", true, true, null)]
[Tag("Housing", 1)]
public class WaxedWoodenFabricBedItem : WorldObjectItem<WaxedWoodenFabricBedObject>
{
	public static readonly HomeFurnishingValue homeValue;

	public override LocString DisplayDescription => Localizer.DoStr("A much more comfortable bed made with fabric.");

	public override DirectionAxisFlags RequiresSurfaceOnSides { get; } = DirectionAxisFlags.Down;

	public override HomeFurnishingValue HomeValue => homeValue;

	static WaxedWoodenFabricBedItem()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		homeValue = new HomeFurnishingValue
		{
			Category = HousingConfig.GetRoomCategory("Bedroom"),
			HouseValue = 5f,
			TypeForRoomLimit = Localizer.DoStr("Bed"),
			DiminishingReturnPercent = 0.3f
		};
		WorldObject.AddOccupancy<WaxedWoodenFabricBedObject>(new List<BlockOccupancy>
		{
			new BlockOccupancy(new Vector3i(0, 0, 0)),
			new BlockOccupancy(new Vector3i(0, 1, 0)),
			new BlockOccupancy(new Vector3i(1, 0, 1)),
			new BlockOccupancy(new Vector3i(0, 0, 1)),
			new BlockOccupancy(new Vector3i(0, 0, 2)),
			new BlockOccupancy(new Vector3i(1, 0, 2)),
			new BlockOccupancy(new Vector3i(1, 1, 2)),
			new BlockOccupancy(new Vector3i(0, 1, 2)),
			new BlockOccupancy(new Vector3i(0, 1, 1)),
			new BlockOccupancy(new Vector3i(1, 1, 1)),
			new BlockOccupancy(new Vector3i(1, 1, 0)),
			new BlockOccupancy(new Vector3i(0, 1, 0)),
			new BlockOccupancy(new Vector3i(1, 0, 0))
		});
	}
}
