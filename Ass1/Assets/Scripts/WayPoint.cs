using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour 
{	
	WayPointHolder waypointHolder;

	void Start()
	{
		waypointHolder = GameObject.Find ("WaypointHolder").GetComponent<WayPointHolder>();
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.name == "ColliderBottom") 
		{
			waypointHolder.UpdateScore ();
		}
		//Debug.Log (col);
	}
}
