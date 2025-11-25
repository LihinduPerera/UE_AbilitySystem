// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UE_AbilitySystem : ModuleRules
{
	public UE_AbilitySystem(ReadOnlyTargetRules Target) : base(Target)
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
			"UE_AbilitySystem",
			"UE_AbilitySystem/Variant_Platforming",
			"UE_AbilitySystem/Variant_Platforming/Animation",
			"UE_AbilitySystem/Variant_Combat",
			"UE_AbilitySystem/Variant_Combat/AI",
			"UE_AbilitySystem/Variant_Combat/Animation",
			"UE_AbilitySystem/Variant_Combat/Gameplay",
			"UE_AbilitySystem/Variant_Combat/Interfaces",
			"UE_AbilitySystem/Variant_Combat/UI",
			"UE_AbilitySystem/Variant_SideScrolling",
			"UE_AbilitySystem/Variant_SideScrolling/AI",
			"UE_AbilitySystem/Variant_SideScrolling/Gameplay",
			"UE_AbilitySystem/Variant_SideScrolling/Interfaces",
			"UE_AbilitySystem/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
