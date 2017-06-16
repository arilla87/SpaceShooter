using UnityEngine;
using System.Collections;

public class RandomRotation : MonoBehaviour 
{
	public float rotation;
	public Rigidbody rb;
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
		rotation = 10.0f;
		rb.angularVelocity = Random.insideUnitSphere * rotation;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
