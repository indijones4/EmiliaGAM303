using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemove : MonoBehaviour {

	public float movementSpeed = 1;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//if left arrow is pressed move cube one unit to the left, if up button is pressed move cube on unit up
		if (Input.GetKeyDown (KeyCode.RightArrow)) 
		{
			transform.position += (Vector3.right * movementSpeed);
			//transform.Translate(Vector3.right);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) 
		{
			//transform.Translate (Vector3.left);
			transform.position += (Vector3.left * movementSpeed);
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) 
		{
			//transform.Translate (Vector3.up);
			transform.position += (Vector3.up * movementSpeed);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
			//transform.Translate (Vector3.down);
			transform.position += (Vector3.down * movementSpeed);
		}
	}
}
