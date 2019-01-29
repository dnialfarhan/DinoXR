using UnityEngine;
using GoogleARCore.Examples.HelloAR;

public class RaycastManager : MonoBehaviour {


	public void Update()
	{

		Vector3 forward = transform.TransformDirection(Vector3.forward);

		RaycastHit hit;

		if (Physics.Raycast(transform.position, forward, out hit)) //if hit a 3D Object
		{
			if ( hit.collider.tag == "Dino") 
			{
				Debug.Log("hit!");
			}
		}

	}
}

