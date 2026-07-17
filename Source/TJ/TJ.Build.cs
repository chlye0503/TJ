// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TJ : ModuleRules
{
	public TJ(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"TJ",
			"TJ/Variant_Platforming",
			"TJ/Variant_Platforming/Animation",
			"TJ/Variant_Combat",
			"TJ/Variant_Combat/AI",
			"TJ/Variant_Combat/Animation",
			"TJ/Variant_Combat/Gameplay",
			"TJ/Variant_Combat/Interfaces",
			"TJ/Variant_Combat/UI",
			"TJ/Variant_SideScrolling",
			"TJ/Variant_SideScrolling/AI",
			"TJ/Variant_SideScrolling/Gameplay",
			"TJ/Variant_SideScrolling/Interfaces",
			"TJ/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
