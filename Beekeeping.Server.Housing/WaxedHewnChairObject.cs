using System;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Housing;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace Beekeeping.Server.Housing;

[Serialized]
[RequireComponent(typeof(PropertyAuthComponent), null)]
[RequireComponent(typeof(HousingComponent), null)]
[RequireComponent(typeof(SolidAttachedSurfaceRequirementComponent), null)]
[RequireComponent(typeof(MountComponent), null)]
[Ecopedia("Housing Objects", "Seating", false, true, "Waxed HewnChair Item")]
public class WaxedHewnChairObject : WorldObject, IRepresentsItem
{
	public override LocString DisplayName => Localizer.DoStr("Waxed Hewn Chair");

	public new virtual TableTextureMode TableTexture => TableTextureMode.Wood;

	public virtual Type RepresentedItemType => typeof(WaxedHewnChairItem);

	protected override void Initialize()
	{
		GetComponent<HousingComponent>().HomeValue = WaxedHewnChairItem.homeValue;
		GetComponent<MountComponent>().Initialize(1);
	}
}
