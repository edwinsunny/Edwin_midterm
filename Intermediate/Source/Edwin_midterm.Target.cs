using UnrealBuildTool;

public class Edwin_midtermTarget : TargetRules
{
	public Edwin_midtermTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Edwin_midterm");
	}
}
