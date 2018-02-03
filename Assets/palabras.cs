using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class palabras : MonoBehaviour {
    public InputField texbox1;
    public string a ;
    
	// Use this for initialization
	void Start () {
        a = "a";
        texbox1.text.Replace("aaaaa", "\n"); 
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
