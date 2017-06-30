using UnityEngine;
using System.Collections;

public class DestruirPassatUnTemps : MonoBehaviour 
{
	public float tempsDestruccio;
	// Use this for initialization
	void Start () 
	{
		Destroy(gameObject, tempsDestruccio);
	}

}
