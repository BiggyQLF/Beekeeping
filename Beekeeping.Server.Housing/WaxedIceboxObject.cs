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
[RequireComponent(typeof(LinkComponent), null)]
[RequireComponent(typeof(HousingComponent), null)]
[RequireComponent(typeof(SolidAttachedSurfaceRequirementComponent), null)]
[RequireComponent(typeof(PublicStorageComponent), null)]
[Ecopedia("Housing Objects", "Kitchen", false, true, "Waxed Icebox Item")]
public class WaxedIceboxObject : WorldObject, IRepresentsItem
{
	public override LocString DisplayName => Localizer.DoStr("Waxed Icebox");

	public new virtual TableTextureMode TableTexture => TableTextureMode.Wood;

	public virtual Type RepresentedItemType => typeof(WaxedIceboxItem);

	protected override void Initialize()
	{
		GetComponent<HousingComponent>().HomeValue = WaxedIceboxItem.homeValue;
		PublicStorageComponent component = GetComponent<PublicStorageComponent>();
		component.Initialize(16);
		component.ShelfLifeMultiplier = 1.2f;
		component.Storage.AddInvRestriction(new FoodStorageRestriction());
		component.Storage.AddInvRestriction(new StackLimitRestriction(200));
	}
}
