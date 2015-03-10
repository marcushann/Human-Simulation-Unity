using UnityEngine;
using System.Collections;
using System;

public class simulationTime : MonoBehaviour {

	public static int speedModifier = 1000;

	private static float Seconds = 0;
	private static float Minutes = 0;
	private static float Hours = 0;
	private static simulationTime instance = null;
	private static readonly object padlock = new object();

	// Use this for initialization
	void Start () {

	}


	// Update is called once per frame
	void Update () {
		AddSecond ();
	}

	#region Time Simulation
	void AddSecond(){
		if ((Seconds + 1)>= 60F) {
			Seconds = 0;
			AddMinute ();
		} else {
			Seconds += ((1 * UnityEngine.Time.deltaTime) * speedModifier);
		}
	}

	void AddMinute(){
		if ((Minutes + 1) >= 60F) {
			Minutes = 0;
			AddHour();
		} else {
			Minutes += 1;
		}
	}

	void AddHour(){
		if ((Hours + 1) >= 24F) {
			Hours = 0;
			Minutes = 0;
			Seconds = 0;
		} else {
			Hours += 1;
		}
	}
	#endregion

	#region public functions
	public int getSecond(){
		return Convert.ToInt32(Seconds);
	}

	public int getMinute(){
		return Convert.ToInt32(Minutes);
	}

	public int getHour(){
		return Convert.ToInt32(Hours);
	}
	#endregion
}