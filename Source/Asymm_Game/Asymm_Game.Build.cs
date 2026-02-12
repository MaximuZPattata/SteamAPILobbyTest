// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Asymm_Game : ModuleRules
{
	public Asymm_Game(ReadOnlyTargetRules Target) : base(Target)
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
			"Asymm_Game",
			"Asymm_Game/Variant_Platforming",
			"Asymm_Game/Variant_Platforming/Animation",
			"Asymm_Game/Variant_Combat",
			"Asymm_Game/Variant_Combat/AI",
			"Asymm_Game/Variant_Combat/Animation",
			"Asymm_Game/Variant_Combat/Gameplay",
			"Asymm_Game/Variant_Combat/Interfaces",
			"Asymm_Game/Variant_Combat/UI",
			"Asymm_Game/Variant_SideScrolling",
			"Asymm_Game/Variant_SideScrolling/AI",
			"Asymm_Game/Variant_SideScrolling/Gameplay",
			"Asymm_Game/Variant_SideScrolling/Interfaces",
			"Asymm_Game/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
