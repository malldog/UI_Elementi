﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VardaParadisana : MonoBehaviour {
	public int kadruSk = 0;
	// Use this for initialization
	void Start () {
		Debug.Log("Uzsakta programma! Tu esi "+kadruSk);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Kadrs "+kadruSk);
		kadruSk++;
	}
}
