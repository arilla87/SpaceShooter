using UnityEngine;
using System.Collections;

[System.Serializable]
public class AreaJoc
{
	public float xMin;
	public float xMax;
	public float zMin;
	public float zMax;

	public void Start()
	{
		xMin = -11.30f;
		xMax = 11.30f;
		zMin = -2.0f;
		zMax = 21.0f;
	}

}

public class PlayerController : MonoBehaviour 
{
	private float movimentHoritzontal;
	private float movimentVertical;
	public float forca;
	public float inclinacio;
	private Rigidbody rb;

	public GameObject shoot;
	public Transform shootSpawn;

	public AreaJoc areaJoc;

	private float nextFire;
	private float fireRate;

	// Use this for initialization
	void Start () 
	{
		forca = 10.0f;
		rb = GetComponent<Rigidbody> ();
		inclinacio = 4.0f;
		nextFire = 0.0f;
		fireRate = 0.3f;
		areaJoc.Start ();


	}

	void FixedUpdate()
	{
		movimentHoritzontal = Input.GetAxis ("Horizontal");
		movimentVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (movimentHoritzontal, 0.0f, movimentVertical);
		rb.velocity = movement * forca;

		rb.position = new Vector3 (Mathf.Clamp (rb.position.x, areaJoc.xMin, areaJoc.xMax), 0.0f, 
			Mathf.Clamp (rb.position.z, areaJoc.zMin, areaJoc.zMax));

		rb.rotation = Quaternion.Euler(0.0f,0.0f,rb.velocity.x * -inclinacio);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButton ("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate (shoot, shootSpawn.position, shootSpawn.rotation);
		}
	}
}
