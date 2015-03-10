using UnityEngine;
using System.Collections;

public class timeText : MonoBehaviour {
	simulationTime current;

	// Use this for initialization
	void Start () {
		current = new simulationTime();
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<UnityEngine.UI.Text>().text = current.getHour().ToString() + ":" + current.getMinute().ToString() + ":" + current.getSecond().ToString();
	}
}