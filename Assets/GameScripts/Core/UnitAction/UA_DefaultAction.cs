using UnityEngine;
//using UnityEditor;
using System;
using System.Collections;
using System.Collections.Generic;
//using System.Linq;

public class UA_DefaultAction : UActionBase {
	
	public string idle = "Idle";
	public string walk = "Walk";
	
	public override bool CanSwitch(UActionBase other) {
		return true;
	}
	
	public override void Active() {
		isProcess = true;
		unitBehaviour.StartCoroutine(IEProcess());
	}
	
	public override IEnumerator IEProcess() {
		yield break;
	}
	
	public override void Stop() {
		isProcess = false;
		unitBehaviour.crtAction = null;
	}
}
