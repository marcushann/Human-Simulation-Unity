using UnityEngine;
using System.Collections;
using System;

public class tirednessText : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float tiredness = 0;
		
		GameObject[] people = GameObject.FindGameObjectsWithTag("simulated");
		foreach(GameObject person in people){
			tiredness += person.GetComponent<humanSimulator>().getTiredness();
		}
		tiredness = tiredness / people.Length;
		
		gameObject.GetComponent<UnityEngine.UI.Text> ().text = "Average Tiredness: " + Convert.ToInt32(tiredness).ToString ();
	} 
}