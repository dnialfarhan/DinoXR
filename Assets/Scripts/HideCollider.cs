using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCollider : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag ("Hide"))
		{
			other.GetComponent<Renderer>().enabled = false;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Hide"))
		{
			other.GetComponent<Renderer>().enabled = true;
		}
	}
}
