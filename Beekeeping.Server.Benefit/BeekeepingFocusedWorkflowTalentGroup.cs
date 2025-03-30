using System;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace Beekeeping.Server.Benefit;

[Serialized]
[LocDisplayName("Focused Workflow: Beekeeping")]
public class BeekeepingFocusedWorkflowTalentGroup : TalentGroup
{
	public override LocString DisplayDescription { get; } = Localizer.DoStr("Doubles the speed of related tables when alone.");

	public BeekeepingFocusedWorkflowTalentGroup()
	{
		base.Talents = new Type[1] { typeof(BeekeepingFocusedSpeedTalent) };
		OwningSkill = typeof(BeekeepingSkill);
		base.Level = 3;
	}
}
