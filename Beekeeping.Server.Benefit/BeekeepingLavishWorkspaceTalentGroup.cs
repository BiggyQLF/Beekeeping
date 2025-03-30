using System;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace Beekeeping.Server.Benefit;

[Serialized]
[LocDisplayName("Lavish Workspace: Beekeeping")]
public class BeekeepingLavishWorkspaceTalentGroup : TalentGroup
{
	public override LocString DisplayDescription { get; } = Localizer.DoStr("Increases the tier requirement of tables by 0.2, but reduces the resources needed by 5 percent.");

	public BeekeepingLavishWorkspaceTalentGroup()
	{
		base.Talents = new Type[2]
		{
			typeof(BeekeepingLavishResourcesTalent),
			typeof(BeekeepingLavishReqTalent)
		};
		OwningSkill = typeof(BeekeepingSkill);
		base.Level = 6;
	}
}
