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
[RequireComponent(typeof(LinkComponent), null)]
[RequireComponent(typeof(HousingComponent), null)]
[RequireComponent(typeof(PublicStorageComponent), null)]
[RequireComponent(typeof(RoomRequirementsComponent), null)]
[RequireComponent(typeof(SolidAttachedSurfaceRequirementComponent), null)]
[RequireRoomContainment]
[RequireRoomMaterialTier(1.8f, new Type[] { })]
[Ecopedia("Housing Objects", "Living Room", false, true, "Wax ShelfCabinet Item")]
public class WaxedShelfCabinetObject : WorldObject, IRepresentsItem
{
	public override LocString DisplayName => Localizer.DoStr("Waxed Shelf Cabinet");

	public new virtual TableTextureMode TableTexture => TableTextureMode.Wood;

	public virtual Type RepresentedItemType => typeof(WaxedShelfCabinetItem);

	protected override void Initialize()
	{
		GetComponent<HousingComponent>().HomeValue = WaxedShelfCabinetItem.homeValue;
		PublicStorageComponent component = GetComponent<PublicStorageComponent>();
		component.Initialize(9);
		component.Storage.AddInvRestriction(new NotCarriedRestriction());
	}
}
