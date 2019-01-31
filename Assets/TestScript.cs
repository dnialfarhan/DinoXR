using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

	public GameObject mesh;

	 void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag =="MainCamera")
		{
			mesh.SetActive(true);
			Debug.Log("TailHit!");
		}
	}
}
