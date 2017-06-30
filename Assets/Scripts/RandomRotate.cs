using UnityEngine;
using System.Collections;

public class RandomRotate : MonoBehaviour 
{
	public Rigidbody rb;
	public float rotacio;

	// Use this for initialization
	void Start () 
	{
		rotacio = 5.0f;
		rb = GetComponent<Rigidbody> ();
		rb.angularVelocity = Random.insideUnitSphere * rotacio;
	}
}
