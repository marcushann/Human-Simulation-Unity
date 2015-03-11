using UnityEngine;
using System.Collections;

public class jobHappinessText : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float happiness = 0;

		GameObject[] people = GameObject.FindGameObjectsWithTag("simulated");
		foreach(GameObject person in people){
			happiness += person.GetComponent<humanSimulator>().getJobHappiness();
		}
		happiness = happiness / people.Length;

		gameObject.GetComponent<UnityEngine.UI.Text> ().text = "Average Job Happiness: " + happiness.ToString ();
	} 
}