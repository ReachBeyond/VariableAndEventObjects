
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ReachBeyond.VariableObjects;

public class UseSoAndSo : MonoBehaviour {

	public IntReference rwInt;
	public IntConstReference roInt;

	// Use this for initialization
	void Start () {
		#if REACHBEYOND_VARIABLES
		Debug.Log("REACHBEYOND_VARIABLES");
		#endif

		int testOne = 5;
		int testTwo = 5;

		Debug.Log(testOne + rwInt);
		Debug.Log(testTwo + roInt);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
