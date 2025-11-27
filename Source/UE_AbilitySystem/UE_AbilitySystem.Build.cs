// Fill out your copyright notice in the Description page of Project Settings.

using System.IO;
using UnrealBuildTool;

public class UE_AbilitySystem : ModuleRules
{
	public UE_AbilitySystem(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] { "GameplayAbilities", "GameplayTasks", "GameplayTags" });

        PublicIncludePaths.Add(ModuleDirectory); // Add the module root
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "AttributeSets")); // Subfolder
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Characters")); // Subfolder

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}
