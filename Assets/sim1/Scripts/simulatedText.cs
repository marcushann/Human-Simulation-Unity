using UnityEngine;
using System.Collections;

public class simulatedText : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<UnityEngine.UI.Text>().text = "Currently Simulating: " + GameObject.FindGameObjectsWithTag("simulated").Length.ToString () + " People";
	}
}