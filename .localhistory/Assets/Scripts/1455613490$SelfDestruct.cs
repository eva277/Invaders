﻿using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {
    [SerializeField]
    private float LifeTime = 2;

	// Use this for initialization
	void Start () {
        Invoke("Destroy",LifeTime);
	}
	
    void Destroy()
    {
        Destroy(this);
    }
}
