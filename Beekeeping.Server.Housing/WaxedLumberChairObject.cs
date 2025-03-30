using System;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Housing;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Property;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace Beekeeping.Server.Housing;

[Serialized]
[RequireComponent(typeof(PropertyAuthComponent), null)]
[RequireComponent(typeof(HousingComponent), null)]
[RequireComponent(typeof(MountComponent), null)]
[RequireComponent(typeof(RoomRequirementsComponent), null)]
[RequireComponent(typeof(SolidAttachedSurfaceRequirementComponent), null)]
[RequireRoomContainment]
[RequireRoomMaterialTier(1.8f, new Type[] { })]
[Ecopedia("Housing Objects", "Seating", false, true, "Waxed LumberChair Item")]
public class WaxedLumberChairObject : WorldObject, IRepresentsItem
{
	public override LocString DisplayName => Localizer.DoStr("Waxed Lumber Chair");

	public new virtual TableTextureMode TableTexture => TableTextureMode.Wood;

	public virtual Type RepresentedItemType => typeof(WaxedLumberChairItem);

	protected override void Initialize()
	{
		GetComponent<HousingComponent>().HomeValue = WaxedLumberChairItem.homeValue;
		GetComponent<MountComponent>().Initialize(1);
	}
}
