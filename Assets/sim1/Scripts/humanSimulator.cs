using UnityEngine;
using System.Collections;

public class humanSimulator : MonoBehaviour {

	public int workStartHour;
	public int workEndHour;
	public GameObject workPlace;
	public GameObject home;

	private simulationTime time;
	private float jobHappiness;

	// Use this for initialization
	void Start () {
		time = new simulationTime ();
		updateJobHappiness ();
	}
	
	// Update is called once per frame
	void Update () {
		if ((time.getHour () >= workStartHour) && (time.getHour () <= workEndHour)) {
			gameObject.GetComponent<NavMeshAgent> ().destination = workPlace.transform.position ;
		} else {
			gameObject.GetComponent<NavMeshAgent> ().destination = home.transform.position;
		}
	}

	void updateJobHappiness(){
		int workingHours = workEndHour - workStartHour;
		int pay = workPlace.GetComponent<workplaceMasterController> ().pay;

		jobHappiness = pay - (workingHours * 1000);
	}

	public float getJobHappiness(){
		return jobHappiness;
	}
}
