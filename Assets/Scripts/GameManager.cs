using UnityEngine.UI;
using UnityEngine;

using System.Collections;

public class GameManager : MonoBehaviour
{
	public GameObject asteroidPrefab;
	public Vector3 posSpawnAsteriod;
	public int numAsteroides;
	public float esperaAsteroids;
	public float esperaOnada;

	public int deadASteroids;

	public Text score;
	public Text gameOver;

	public bool playerIsAlive;

	// Use this for initialization
	void Start () 
	{
		playerIsAlive = true;
		gameOver.IsActive();
		deadASteroids = 0;
		StartCoroutine(SpawnAsteroids ());
	}
	
	IEnumerator SpawnAsteroids()
	{
		while (playerIsAlive) 
		{	
			for (int index = 0; index < numAsteroides; index++) 
			{
				Vector3 posSortida = new Vector3 (Random.Range (-posSpawnAsteriod.x, posSpawnAsteriod.x), 
					                    posSpawnAsteriod.y, posSpawnAsteriod.z);
				Quaternion rotacioAsteroid = Quaternion.identity;
				Instantiate (asteroidPrefab, posSortida, rotacioAsteroid);
				yield return new WaitForSeconds (esperaAsteroids);
			}
			yield return new WaitForSeconds (esperaOnada);
		}
	}

	public void ActualitzarPuntuacio(int asteroidsMorts)
	{
		deadASteroids = deadASteroids + asteroidsMorts;
		MostrarPuntacio ();

	}

	public void GameOver()
	{
		gameOver.text = "Game Over";
	}

	public void EndGame(bool final)
	{
		playerIsAlive = final;
	}

	void MostrarPuntacio()
	{
		score.text = "Has matat: " + deadASteroids;
	}
		
}
