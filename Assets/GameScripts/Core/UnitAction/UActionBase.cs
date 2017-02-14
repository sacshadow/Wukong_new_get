using UnityEngine;
using System.Collections;

public class UActionBase : MonoBehaviour {

	public UnitBehaviour unitBehaviour;
	public UActionBase reference;
	public bool isProcess = false;
	
	public UnitBasic unitBasic {get {return unitBehaviour.unitBasic; }}
	
	public virtual bool CanSwitch(UActionBase other) {
		return false;
	}
	
	public virtual void Active() {
		isProcess = true;
		unitBehaviour.StartCoroutine(IEProcess());
	}
	
	public virtual IEnumerator IEProcess() {
		yield break;
	}
	
	public virtual void Stop() {
		isProcess = false;
		unitBehaviour.crtAction = null;
	}
}
