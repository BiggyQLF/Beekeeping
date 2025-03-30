using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Systems.Tooltip;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace Beekeeping.Server.Housing;

[Serialized]
[LocDisplayName("Waxed Wooden Floor Lamp")]
[Ecopedia("Housing Objects", "Lighting", true, true, null)]
[Tag("Housing", 1)]
public class WaxedWoodenFloorLampItem : WorldObjectItem<WaxedWoodenFloorLampObject>
{
	public static readonly HomeFurnishingValue homeValue;

	public override LocString DisplayDescription => Localizer.DoStr("A more modern way to light up a room. This time from the floor.");

	public override DirectionAxisFlags RequiresSurfaceOnSides { get; } = DirectionAxisFlags.Down;

	public override HomeFurnishingValue HomeValue => homeValue;

	[Tooltip(7, new Type[] { })]
	private unsafe LocString PowerConsumptionTooltip
	{
		get
		{
			//IL_002a: Expected O, but got Ref
			object[] obj = new object[2]
			{
				Text.Info(60),
				null
			};
			ElectricPower electricPower = null;
			obj[1] = ((ElectricPower)(&electricPower)).Name;
			return Localizer.Do(FormattableStringFactory.Create("Consumes: {0}w of {1} power", obj));
		}
	}

	static WaxedWoodenFloorLampItem()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		homeValue = new HomeFurnishingValue
		{
			Category = HousingConfig.GetRoomCategory("Lighting"),
			HouseValue = 2.5f,
			TypeForRoomLimit = Localizer.DoStr("Lights"),
			DiminishingReturnPercent = 0.7f
		};
		WorldObject.AddOccupancy<WaxedWoodenFloorLampObject>(new List<BlockOccupancy>
		{
			new BlockOccupancy(new Vector3i(0, 0, 0)),
			new BlockOccupancy(new Vector3i(0, 1, 0))
		});
	}
}
