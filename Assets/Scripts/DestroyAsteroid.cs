using UnityEngine;
using System.Collections;

public class DestroyAsteroid : MonoBehaviour
{
	public GameObject explosioAsteroid;
	public GameObject explosioNau;
	public GameManager gameManager;
//	public GameObject gameManager2;

	public int asteroidDestruit;

	void Start()
	{
		asteroidDestruit = 0;
		//TODO: Arreglar recollida del gameManager

	//	gameManager2 = GameObject.FindGameObjectWithTag ("GameManager");
	//	gameManager2 = GetComponent<GameManager> ();
	//	gameManager = FindObjectOfType (typeof(GameManager)) as GameManager;
		gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag != "Limit") 
		{	
			if (col.tag == "Projectil")
			{
				Destroy (col.gameObject);
				Instantiate (explosioAsteroid, gameObject.transform.position, gameObject.transform.rotation);
				Destroy (gameObject);
				asteroidDestruit++;
				gameManager.ActualitzarPuntuacio (asteroidDestruit);
			}

			if(col.tag == "Player")
			{
				Instantiate (explosioNau, col.transform.position, col.transform.rotation);
				Destroy (col.gameObject);
				Instantiate (explosioAsteroid, gameObject.transform.position, gameObject.transform.rotation);
				Destroy (gameObject);
				gameManager.GameOver ();
				gameManager.EndGame (false);
			}
		}
	}



}
