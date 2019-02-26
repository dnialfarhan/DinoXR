using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoSelfie : MonoBehaviour {

	public Animation dinoSelfie;
	public float animSpeed = 0.5f;
	
	// Use this for initialization
	void Start () {

		dinoSelfie["Take 001"].speed = animSpeed;
		
	}
	
}
