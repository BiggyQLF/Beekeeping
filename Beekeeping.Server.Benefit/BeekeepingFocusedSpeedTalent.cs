using System;
using Eco.Mods.TechTree;
using Eco.Shared.Serialization;

namespace Beekeeping.Server.Benefit;

[Serialized]
public class BeekeepingFocusedSpeedTalent : FocusedWorkflowTalent
{
	public override bool Base => false;

	public override Type TalentGroupType => typeof(BeekeepingFocusedWorkflowTalentGroup);

	public BeekeepingFocusedSpeedTalent()
	{
		base.Value = 0.5f;
	}
}
