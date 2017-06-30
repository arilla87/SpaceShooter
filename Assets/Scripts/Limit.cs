using UnityEngine;
using System.Collections;

public class Limit : MonoBehaviour {

	void OnTriggerExit(Collider col)
	{
		Destroy (col.gameObject);
	}


}
