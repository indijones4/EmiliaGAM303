using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour {

	public GameObject basketPrefab;
	public int numBaskets = 3;
	public float basketBottonY = -14f;
	public float basketSpacingY = 2f;

	// Use this for initialization
	void Start () 
	{
		for (int i = 0; i < numBaskets; i++) 
		{
			GameObject tBasketGO = Instantiate (basketPrefab) as GameObject;
			Vector3 pos = Vector3.zero;
			pos.y = basketBottonY + (basketSpacingY * i);
			tBasketGO.transform.position = pos;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Get the current screen position of the mouse from Input
		Vector3 mousePos2D = Input.mousePosition; //1

		//The Camera's z position sets how far to push the mouse into 3d
		mousePos2D.z = -Camera.main.transform.position.z; //2

		//Convert the point from 2D screen space into 3D game world space
		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D); //3

		//Move the x position of this Basket to the x position of the Mouse
		Vector3 pos = this.transform.position;
		pos.x = mousePos3D.x;
		this.transform.position = pos;
	}
}
