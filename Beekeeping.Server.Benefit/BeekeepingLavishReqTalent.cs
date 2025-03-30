using System;
using Eco.Mods.TechTree;
using Eco.Shared.Serialization;

namespace Beekeeping.Server.Benefit;

[Serialized]
public class BeekeepingLavishReqTalent : LavishWorkspaceTalent
{
	public override bool Base => false;

	public override Type TalentGroupType => typeof(BeekeepingLavishWorkspaceTalentGroup);

	public BeekeepingLavishReqTalent()
	{
		base.Value = 0.2f;
	}
}
