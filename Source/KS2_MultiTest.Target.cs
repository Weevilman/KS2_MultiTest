// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class KS2_MultiTestTarget : TargetRules
{
	public KS2_MultiTestTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
        ExtraModuleNames.AddRange(new string[] { "KS2_MultiTest" });
		//bUsePCHFiles = false;
		//bUseUnityBuild = false;
    }

	//
	// TargetRules interface.
	//

	/*public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "KS2_MultiTest" } );
	}*/
}
