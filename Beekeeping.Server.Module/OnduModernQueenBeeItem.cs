using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Modules;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace Beekeeping.Server.Module;

[Serialized]
[LocDisplayName("Modern Queen Bee")]
[Weight(1)]
[Tag("QueenBee", 1)]
public class OnduModernQueenBeeItem : EfficiencyModule
{
	public virtual LocString DisplayDescription => Localizer.DoStr("Modern Upgrade. Found in wild beehives");

	public OnduModernQueenBeeItem()
		: base(ModuleTypes.ResourceEfficiency | ModuleTypes.SpeedEfficiency, 0.5f, typeof(BeekeepingSkill), 0.5f)
	{
	}
}
