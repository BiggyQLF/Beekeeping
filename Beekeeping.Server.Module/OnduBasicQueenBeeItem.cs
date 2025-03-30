using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Modules;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace Beekeeping.Server.Module;

[Serialized]
[LocDisplayName("Basic Queen Bee")]
[Weight(1)]
[Tag("QueenBee", 1)]
public class OnduBasicQueenBeeItem : EfficiencyModule
{
	public override LocString DisplayDescription => Localizer.DoStr("Basic Queen bee. Found in wild beehives.");

	public OnduBasicQueenBeeItem()
		: base(ModuleTypes.ResourceEfficiency | ModuleTypes.SpeedEfficiency, 0.7f, typeof(BeekeepingSkill), 0.7f)
	{
	}
}
