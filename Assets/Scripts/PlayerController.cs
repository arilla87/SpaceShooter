using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	private Rigidbody rb;
	private float movimentHoritzontal;
	private float movimentVertical;
	public float velocitat;
	public float xMax, xMin, zMax, zMin;
	public float inclinacio;

	public Transform spawnProjectil;
	public GameObject projectil;

	private float nextFire;
	public float fireRate;
	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		xMin = -9.70f;
		xMax = 9.70f;
		zMin = -4.50f;
		zMax = 20.0f;
		inclinacio = -5.0f;
		fireRate = 0.01f;
		Debug.Log (Time.time);
	}

	void FixedUpdate()
	{
		movimentVertical = Input.GetAxis ("Vertical");
		movimentHoritzontal = Input.GetAxis ("Horizontal");
		Vector3 moviment = new Vector3 (movimentHoritzontal, 0.0f, movimentVertical);

		rb.velocity = (moviment * velocitat) * Time.deltaTime;
		rb.position = new Vector3 (Mathf.Clamp(rb.position.x, xMin,xMax),0.0f,
			Mathf.Clamp(rb.position.z, zMin, zMax));
		rb.rotation = Quaternion.Euler (0.0f, 0.0f, rb.velocity.x * inclinacio);
	}
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown("Jump") && Time.time > nextFire) 
		{
			nextFire = Time.time + fireRate;
			Instantiate (projectil, spawnProjectil.position, spawnProjectil.rotation);
		}
		//Debug.Log (Time.time);

	}
}
