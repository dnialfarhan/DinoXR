
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore.Examples.HelloAR;


public class InstantiateObjectOnTouch : MonoBehaviour
{

	//private GameObject childObject;
	public HelloARController helloAr;
	public enum HoverState { HOVER, NONE };
	public HoverState hover_state = HoverState.NONE;
	public GameObject ui;

	private void Start()
	{
		helloAr._ShowAndroidToastMessage("Awake");
		//ui.SetActive(false);
	}


	//Update is called once per frame
	public void FixedUpdate()
	{


		Vector3 fwd = transform.TransformDirection(Vector3.forward);

		RaycastHit hit;

		if (Physics.Raycast(transform.position, fwd, out hit)) //if hit a 3D Object
		{
			if (hit.transform.tag == "Dino")
			{
				ui.SetActive(true);
				Debug.Log("hit!");
			}


		}
	}
}