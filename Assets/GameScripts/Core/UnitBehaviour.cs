using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class UnitBehaviour : MonoBehaviour {
	
	public Dictionary<string, UActionBase> uaction;
	
	public UActionBase defaultAction, crtAction, nextAction;
	public float lastInputTime = 0;
	
	public void SetAction(params UActionBase[] uaction) {
		this.uaction = new Dictionary<string, UActionBase>();
		foreach(var ua in uaction) AddAction(ua);
	}
	
	public void AddAction(UActionBase uaction) {
		var temp = GetActionReference(uaction);
		this.uaction.Add(GetActionName(temp),temp);
	}
	
	public UActionBase GetActionReference(UActionBase uaction) {
		var temp = Instantiate(uaction) as UActionBase;
		temp.unitBehaviour = this;
		temp.reference = uaction;
		temp.transform.SetParent(this.transform);
		temp.transform.localPosition = Vector3.zero;
		temp.transform.localRotation = Quaternion.identity;
		return temp;
	}
	
	public string GetActionName(UActionBase uaction) {
		return uaction.reference.name;
	}
	
	public virtual void PlayAction(string actionName) {
		PlayAction(uaction[actionName]);
	}
	
	public virtual void PlayAction(UActionBase uaction) {
		if(crtAction != null && !crtAction.CanSwitch(uaction))
			return;
		
		crtAction = uaction;
		crtAction.Active();
	}
	
	public virtual void Stop() {
		StopAllCoroutines();
		if(crtAction != null) crtAction.Stop();
		crtAction = null;
	}
	
	public virtual void Reset() {
		Stop();
		PlayAction(defaultAction);
	}
	
	
	
}
