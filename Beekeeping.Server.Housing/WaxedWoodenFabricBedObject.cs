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
[Ecopedia("Housing Objects", "Bedroom", false, true, "Waxed WoodenFabricBed Item")]
public class WaxedWoodenFabricBedObject : WorldObject, IRepresentsItem
{
	public override LocString DisplayName => Localizer.DoStr("Waxed Wooden Fabric Bed");

	public new virtual TableTextureMode TableTexture => TableTextureMode.Wood;

	public virtual Type RepresentedItemType => typeof(WaxedWoodenFabricBedItem);

	protected override void Initialize()
	{
		GetComponent<HousingComponent>().HomeValue = WaxedWoodenFabricBedItem.homeValue;
		GetComponent<MountComponent>().Initialize(1);
	}
}
