using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	public GameObject asteroid;
	public Vector3 spawnValues;
	// Use this for initialization
	void Start () 
	{
		SpawnAsteroids ();
	}

	void SpawnAsteroids()
	{
		Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (asteroid, spawnPosition, spawnRotation);
	}

}
