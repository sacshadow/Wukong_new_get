using UnityEngine;
using System.Collections;


public enum UState {
	NORMAL = 0,
	AIR,
	GROUNDED,
	
	
	Die = 31,
}

public class UnitState {
	
	public UState ustate;
	
	public bool isAlive = true;
	public float distanceToGround = 0;
	
	public bool isOnGround {
		get {
			return distanceToGround < 0.05f;
		}
	}
}
