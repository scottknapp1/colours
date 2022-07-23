using UnrealBuildTool;

public class JamTarget : TargetRules
{
	public JamTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Jam");
	}
}
