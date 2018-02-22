using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WayPointHolder : MonoBehaviour {

	public float score = 0;
	public float timer;
	public Text scoreText;
	public Text Countdown;
	// Use this for initialization
	void Start () 
	{
		scoreText.text = score.ToString ();
		timer = 30;
		Countdown.text = timer.ToString ("##.##");
	}

	void Update()
	{
		timer -= Time.deltaTime;
		Countdown.text = timer.ToString ("##.##");
	}

	// Update is called once per frame
	public void UpdateScore () 
	{
		score += 100;
		scoreText.text = score.ToString ();
		timer += 10;
		Countdown.text = timer.ToString ("##.##");
	}
}
