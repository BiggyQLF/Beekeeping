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
[RequireComponent(typeof(OnOffComponent), null)]
[RequireComponent(typeof(PropertyAuthComponent), null)]
[RequireComponent(typeof(PowerGridComponent), null)]
[RequireComponent(typeof(PowerConsumptionComponent), null)]
[RequireComponent(typeof(HousingComponent), null)]
[RequireComponent(typeof(RoomRequirementsComponent), null)]
[RequireComponent(typeof(SolidAttachedSurfaceRequirementComponent), null)]
[RequireRoomContainment]
[RequireRoomMaterialTier(1.8f, new Type[] { })]
[Ecopedia("Housing Objects", "Lighting", false, true, "Waxed WoodenFloorLamp Item")]
public class WaxedWoodenFloorLampObject : WorldObject, IRepresentsItem
{
	public override LocString DisplayName => Localizer.DoStr("Waxed Wooden Floor Lamp");

	public new virtual TableTextureMode TableTexture => TableTextureMode.Wood;

	public virtual Type RepresentedItemType => typeof(WaxedWoodenFloorLampItem);

	protected override void Initialize()
	{
		GetComponent<PowerConsumptionComponent>().Initialize(60f);
		GetComponent<PowerGridComponent>().Initialize(10f, (IPowerEnergyType)null);
		GetComponent<HousingComponent>().HomeValue = WaxedWoodenFloorLampItem.homeValue;
	}
}
