using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class3 : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		GetComponent<Rigidbody> ().useGravity = true;
		//GetComponent<SphereCollider> ().isTrigger = true;
		GetComponent<Renderer> ().material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			GetComponent<Rigidbody> ().AddForce(0, 500, 0);
		}
	}
}
