using UnityEngine;
//using UnityEditor;
using System;
using System.Collections;
using System.Collections.Generic;
//using System.Linq;

public class UA_Animation : UActionBase {

	public string animName = "Idle";
	
	public override bool CanSwitch(UActionBase other) {
		return true;
	}
	
	public override IEnumerator IEProcess() {
		unitBasic.Play(animName);
		
		while(true) {
			yield return null;
		}
	}
}
