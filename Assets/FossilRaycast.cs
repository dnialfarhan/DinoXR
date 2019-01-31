using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FossilRaycast : MonoBehaviour {

	public GameObject jawWire, femurWire, tailWire;
	public GameObject jawReal, femurReal, tailReal;

	public GameObject convertDino;

	public GameObject realDino;
	public GameObject fossilDino;

	void Update()
	{

		if (Input.touchCount > 0)
		{
			var ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo))
			{

				if (hitInfo.collider.tag == "JawButton")
				{
					jawWire.SetActive(false);
					jawReal.SetActive(true);
				}

				if (hitInfo.collider.tag == "FemurButton")
				{
					femurWire.SetActive(false);
					femurReal.SetActive(true);
				}

				if (hitInfo.collider.tag == "TailButton")
				{
					tailWire.SetActive(false);
					tailReal.SetActive(true);
				}

				if (jawReal.activeInHierarchy == true && femurReal.activeInHierarchy == true 
					&& tailReal.activeInHierarchy == true)
				{
					convertDino.SetActive(true);
				}

				if(hitInfo.collider.tag == "ConvertDino")
				{
					fossilDino.SetActive(false);
					realDino.SetActive(true);
				}

			}
		}
	}
}
