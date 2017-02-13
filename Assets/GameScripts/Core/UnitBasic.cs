using UnityEngine;
using System.Collections;

public class UnitBasic : MonoBehaviour {
	
	public UnitState unitState;
	
	
	public virtual void Play(string animName) {
		
	}
	
	public virtual void CrossFade(string animName, float fadeTime = 0.15f) {
		
	}
	
	public virtual void Face(Vector3 direction) {
		
	}
	
	public virtual void Move(Vector3 direction, float speed) {
		
	}
	
}
