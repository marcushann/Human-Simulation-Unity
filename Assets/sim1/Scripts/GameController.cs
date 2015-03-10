using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public int spawnRate;
	public GameObject spawnItem;
	public Vector3 spawnLocations;
	public GameObject home;
	public GameObject work;
	public int maxSimulated;

	private float lastSpawn = Time.realtimeSinceStartup;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("timesincestartup: " + Time.realtimeSinceStartup.ToString() + " lastSpawn: " + lastSpawn.ToString());
		if((Time.realtimeSinceStartup - lastSpawn > spawnRate) && GameObject.FindGameObjectsWithTag("simulated").Length < maxSimulated){
			Debug.Log ("spawning new");
			//Spawn new sim object
			Vector3 position = new Vector3(Random.Range (-spawnLocations.x, spawnLocations.x), Random.Range (-spawnLocations.y, spawnLocations.y), 0);
			Quaternion rotation = Quaternion.identity;
			spawnItem.GetComponent<humanSimulator>().home = home;
			spawnItem.GetComponent<humanSimulator>().workPlace = work;
			spawnItem.GetComponent<humanSimulator>().workStartHour = Random.Range (0, 23);
			spawnItem.GetComponent<humanSimulator>().workEndHour = Random.Range (0, 23);
			Instantiate( spawnItem, position, rotation);
			lastSpawn = Time.realtimeSinceStartup;
		}
	}
}
