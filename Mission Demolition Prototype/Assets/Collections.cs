using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour {

	public GameObject[] waypoints;

	public List<GameObject> personList;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Alpha1)) 
		{
			foreach (GameObject go in personList) 
			{
				Debug.Log (go.GetComponent<Person>().personName);
			}

		}
	}
}
