// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class FilePluginProjectEditorTarget : TargetRules
{
	public FilePluginProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		//Type = TargetType.Editor;
		//DefaultBuildSettings = BuildSettingsVersion.V2;
		//ExtraModuleNames.Add("FilePluginProject");

        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V5;  // Use the latest build settings for Unreal Engine 5.4
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;  // Use the latest include order to avoid compatibility issues
        bOverrideBuildEnvironment = true;  // Force override of the build environment to avoid conflicts
        ExtraModuleNames.Add("FilePluginProject");
    }
}
