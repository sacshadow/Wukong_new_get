using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class SpineUnit : UnitBasic {
	
	public SkeletonAnimation spineAnimation;
	
	public override void Play(string animName) {
		spineAnimation.state.SetAnimation(0,animName,true);
	}
	
}
