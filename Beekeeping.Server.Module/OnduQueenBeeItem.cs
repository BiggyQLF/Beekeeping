using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Modules;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace Beekeeping.Server.Module;

[Serialized]
[LocDisplayName("Queen Bee")]
[Weight(1)]
[Tag("QueenBee", 1)]
public class OnduQueenBeeItem : EfficiencyModule
{
	public virtual LocString DisplayDescription => Localizer.DoStr("Basic Upgrades. Found in wild beehives.");

	public OnduQueenBeeItem()
		: base(ModuleTypes.ResourceEfficiency | ModuleTypes.SpeedEfficiency, 0.8f, typeof(BeekeepingSkill), 0.8f)
	{
	}
}
