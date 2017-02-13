using UnityEngine;
using System.Collections;

public class UActionBase : MonoBehaviour {

	public UnitBehaviour unitBehaviour;
	public UActionBase reference;
	public bool isProcess = false;
	
	
	public virtual bool CanSwitch(UActionBase other) {
		return false;
	}
	
	public virtual void Active() {
		
	}
	
	public virtual IEnumerator Process() {
		yield break;
	}
	
	public virtual void Stop() {
		
	}
}
