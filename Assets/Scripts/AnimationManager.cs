using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

	/*public ParallaxFx bgParallax;
	public ParallaxFx floorParallax;
	public ParallaxFx groundParallax;

	public UIManager uiManager;

	public GameObject trexIdle;
	public GameObject trexWalk;
	public GameObject trexRun;
	public GameObject trexHunt;


	public void Walk()
	{
		trexWalk.SetActive(true);
		trexRun.SetActive(false);
		trexHunt.SetActive(false);
		trexIdle.SetActive(false);

		bgParallax.ScrollX = -0.075f;
		floorParallax.ScrollX = 0.5f;
		groundParallax.ScrollX = -1f;

		uiManager.animChild.SetActive(false);

	}

	public void Run()
	{
		trexWalk.SetActive(false);
		trexRun.SetActive(true);
		trexHunt.SetActive(false);
		trexIdle.SetActive(false);

		bgParallax.ScrollX = -0.2f;
		floorParallax.ScrollX = 0.85f;
		groundParallax.ScrollX = -1.75f;

		uiManager.animChild.SetActive(false);	

	}

	public void Hunt()
	{
		trexWalk.SetActive(false);
		trexRun.SetActive(false);
		trexHunt.SetActive(true);
		trexIdle.SetActive(false);

		bgParallax.ScrollX = 0;
		floorParallax.ScrollX = 0f;
		groundParallax.ScrollX = 0f;

		uiManager.animChild.SetActive(false);

	}*/

	public Animation test;

	public void Move()
	{
		test.Play();
	}
}
