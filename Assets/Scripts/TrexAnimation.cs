using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrexAnimation : MonoBehaviour {

	public Animator trexAnim;

	// Use this for initialization
	void Start () {

		trexAnim = GetComponent<Animator>();

	}
	

	public void Run()
	{
		trexAnim.SetBool("Run", true);
	}
}
