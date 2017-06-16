using UnityEngine;
using System.Collections;

public class DestroyAsteroid : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerExplosion;
	// Use this for initialization
	void Start ()
	{
		
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag != "Limit")
		{
			if (col.tag == "Player")
			{
				Instantiate (playerExplosion, col.transform.position, col.transform.rotation);
			}
			Instantiate (explosion, transform.position, transform.rotation);
			Destroy (col.gameObject);
			Destroy (gameObject);
		}
	}
		
}
