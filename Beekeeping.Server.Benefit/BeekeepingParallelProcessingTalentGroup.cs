using System;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace Beekeeping.Server.Benefit;

[Serialized]
[LocDisplayName("Parallel Processing: Beekeeping")]
public class BeekeepingParallelProcessingTalentGroup : TalentGroup
{
	public override LocString DisplayDescription { get; } = Localizer.DoStr("Increases the crafting speed of related tables when they share a room with the same tables by 20 percent.");

	public BeekeepingParallelProcessingTalentGroup()
	{
		base.Talents = new Type[1] { typeof(BeekeepingParallelSpeedTalent) };
		OwningSkill = typeof(BeekeepingSkill);
		base.Level = 3;
	}
}
