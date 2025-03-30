using System;
using Eco.Mods.TechTree;
using Eco.Shared.Serialization;

namespace Beekeeping.Server.Benefit;

[Serialized]
public class BeekeepingLavishResourcesTalent : LavishWorkspaceTalent
{
	public override bool Base => false;

	public override Type TalentGroupType => typeof(BeekeepingLavishWorkspaceTalentGroup);

	public BeekeepingLavishResourcesTalent()
	{
		base.Value = 0.95f;
	}
}
