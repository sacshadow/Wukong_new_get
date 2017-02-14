using UnityEngine;
//using UnityEditor;
using System;
using System.Collections;
using System.Collections.Generic;
//using System.Linq;

public class KA {
	public KeyCode keyCode;
	public string anim;
}

public class CharacterTest : MonoBehaviour {
	
	public UnitBehaviour uBehaviour;
	public UnitBasic uBasic;
	
	public List<KA> ka;
	
	private void AddKA(KeyCode key, string anim) {
		ka.Add(new KA{keyCode = key, anim = anim});
	}
	
	// Use this for initialization
	void Start () {
		ka = new List<KA>();
		
		AddKA(KeyCode.J,"daiji");
		AddKA(KeyCode.K,"daiji2");
		AddKA(KeyCode.L,"chongci_C1");
		
	}
	
	// Update is called once per frame
	void Update () {
		foreach(var temp in ka) {
			if(Input.GetKeyDown(temp.keyCode))
				uBasic.Play(temp.anim);
		}
	}
}
