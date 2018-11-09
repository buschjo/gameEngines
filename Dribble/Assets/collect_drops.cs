using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect_drops : MonoBehaviour {

	public Rigidbody drop;
	//how long between each spawn
	public float spawnTime = 3f; 	
	//an array of the spawn points this enemy can spawn from
	public Transform[] spawnPoints; 	

	// Use this for initialization
	void Start () {
		transform.position = Random.insideUnitCircle * 5;
		InvokeRepeating("drop", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void Spawn() {
		//find random index between zero and one less than the number of spawn points
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		//create an instance of enemy prefab at randomly selected spawn point's position and rotation
		Instantiate(drop, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}
