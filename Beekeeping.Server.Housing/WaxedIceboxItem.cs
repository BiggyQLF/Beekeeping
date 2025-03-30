using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Eco.Core.Items;
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
[LocDisplayName("Waxed Icebox")]
[Ecopedia("Housing Objects", "Kitchen", true, true, null)]
[Tag("Housing", 1)]
public class WaxedIceboxItem : WorldObjectItem<WaxedIceboxObject>
{
	public static readonly HomeFurnishingValue homeValue;

	public override LocString DisplayDescription => Localizer.DoStr("A waxed box of ice. It's in the name!");

	public override DirectionAxisFlags RequiresSurfaceOnSides { get; } = DirectionAxisFlags.Down;

	public override HomeFurnishingValue HomeValue => homeValue;

	[Tooltip(50, new Type[] { })]
	public TooltipSection UpdateTooltip()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		return new TooltipSection(Localizer.Do(FormattableStringFactory.Create("{0} total shelf life by: {1}", Localizer.DoStr("Increases"), Text.InfoLight(Text.Percent(0.2f)))).Dash());
	}

	static WaxedIceboxItem()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		homeValue = new HomeFurnishingValue
		{
			Category = HousingConfig.GetRoomCategory("Kitchen"),
			HouseValue = 2f,
			TypeForRoomLimit = Localizer.DoStr("Food Storage"),
			DiminishingReturnPercent = 0.3f
		};
		WorldObject.AddOccupancy<WaxedIceboxItem>(new List<BlockOccupancy>
		{
			new BlockOccupancy(new Vector3i(0, 0, 0)),
			new BlockOccupancy(new Vector3i(-1, 0, 0)),
			new BlockOccupancy(new Vector3i(-1, 1, 0)),
			new BlockOccupancy(new Vector3i(0, 1, 0))
		});
	}
}
