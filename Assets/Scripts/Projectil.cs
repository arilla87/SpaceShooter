using UnityEngine;
using System.Collections;

public class Projectil : MonoBehaviour 
{
	private Rigidbody rb;
	public float velocitat;
	// Use this for initialization
	void Start () 
	{
	//	velocitat = 8.5f;
		rb = GetComponent<Rigidbody> ();
		rb.velocity = Vector3.forward * velocitat;
	}
}
