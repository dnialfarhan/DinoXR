using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacerManager_Level3 : MonoBehaviour {

	public GameObject jawMesh, femurMesh, tailMesh;

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag ==("Jaw"))
		{
			JawPlace();
		}

		if(other.gameObject.tag == ("Femur"))
		{
			FemurPlace();
		}

		if (other.gameObject.tag == ("Tail"))
		{
			TailPlace();
		}
	}

	public void JawPlace()
	{
		
	}

	public void FemurPlace()
	{

	}

	public void TailPlace()
	{

	}
}
