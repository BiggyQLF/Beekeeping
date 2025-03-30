using System;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace Beekeeping.Server.Benefit;

[Serialized]
[LocDisplayName("Frugal Workspace: Beekeeping")]
public class BeekeepingFrugalWorkspaceTalentGroup : TalentGroup
{
	public override LocString DisplayDescription { get; } = Localizer.DoStr("Lowers the tier requirement of related tables by 0.2");

	public BeekeepingFrugalWorkspaceTalentGroup()
	{
		base.Talents = new Type[1] { typeof(BeekeepingFrugalReqTalent) };
		OwningSkill = typeof(BeekeepingSkill);
		base.Level = 6;
	}
}
