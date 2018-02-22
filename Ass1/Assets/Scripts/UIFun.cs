using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFun : MonoBehaviour {

	public Text CountdownTimer;
	public Text playerInput;
	float Countdownfrom = 20f;
	float Counter;

	// Use this for initialization
	void Start () 
	{
		Counter = Countdownfrom;
		CountdownTimer.text = Counter.ToString();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Counter -= Time.deltaTime;
		if (Counter > 0) 
		{
			CountdownTimer.text = Counter.ToString ("##.##");
		} 
		else 
		{
			CountdownTimer.color = Color.red;
			CountdownTimer.text = ("00.00");
		}
	}
}
