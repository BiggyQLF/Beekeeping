using System;
using Eco.Mods.TechTree;
using Eco.Shared.Serialization;

namespace Beekeeping.Server.Benefit;

[Serialized]
public class BeekeepingFrugalReqTalent : FrugalWorkspaceTalent
{
	public override bool Base => false;

	public override Type TalentGroupType => typeof(BeekeepingFrugalWorkspaceTalentGroup);

	public BeekeepingFrugalReqTalent()
	{
		base.Value = -0.2f;
	}
}
