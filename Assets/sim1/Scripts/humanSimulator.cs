using UnityEngine;
using System.Collections;

public class humanSimulator : MonoBehaviour {

	public int workStartHour;
	public int workEndHour;
	public GameObject workPlace;
	public GameObject home;

	private simulationTime time;
	private float jobHappiness;
	private int tiredness = 0;
	private int health = 100;
	private int tirednessThreshold = 50000;

	// Use this for initialization
	void Start () {
		time = new simulationTime ();
		updateJobHappiness ();
	}
	
	// Update is called once per frame
	void Update () {
		if ((time.getHour () >= workStartHour) && (time.getHour () <= workEndHour) && !(tiredness > tirednessThreshold)) {
			gameObject.GetComponent<NavMeshAgent> ().destination = workPlace.transform.position ;
		} else {
			gameObject.GetComponent<NavMeshAgent> ().destination = home.transform.position;
		}

		updateTiredness ();
	}

	void updateJobHappiness(){
		int workingHours = workEndHour - workStartHour;
		int pay = workPlace.GetComponent<workplaceMasterController> ().pay;

		jobHappiness = pay - (workingHours * 1000);
	}

	void updateTiredness(){
		if ((time.getHour () >= workStartHour) && (time.getHour () <= workEndHour)) {
			tiredness ++;
		} else {
			if(tiredness > 0){
				tiredness--;
			}
		}
	}

	public float getJobHappiness(){
		return jobHappiness;
	}

	public int getTiredness(){
		return tiredness;
	}
}
