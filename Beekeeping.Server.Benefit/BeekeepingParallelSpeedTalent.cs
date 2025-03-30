using System;
using Eco.Mods.TechTree;
using Eco.Shared.Serialization;

namespace Beekeeping.Server.Benefit;

[Serialized]
public class BeekeepingParallelSpeedTalent : ParallelProcessingTalent
{
	public override bool Base => false;

	public override Type TalentGroupType => typeof(BeekeepingParallelProcessingTalentGroup);

	public BeekeepingParallelSpeedTalent()
	{
		base.Value = 0.8f;
	}
}
