using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

	//Trex Object
	public GameObject trexWalk, trexRun, trexHunt, trexStay;

	//Trex Animation
	public Animation walkAnim, runAnim, huntAnim;

	//Trex Animation Speed
	public float trexrunSpeed;
	
	//Treadmill Object
	public GameObject jungleTreadmill, openareaTreadmill, desertTreadmill;

	//Treadmill Animation
	public Animation jungleAnim, openareaAnim, desertAnim;

	//Treadmill Animation Speed
	public float idleSpeed = 0.0f;
	public float walkSpeed = -0.35f;
	public float runSpeed = -1.0f;

	//Info Panel
	public GameObject InfoPanel;


	public void SceneIdle()
	{
		
		jungleAnim["Jungle"].speed = idleSpeed;
		this.jungleAnim.Play();

		openareaAnim["OpenArea"].speed = idleSpeed;
		this.openareaAnim.Play();

		desertAnim["Desert"].speed = idleSpeed;
		this.desertAnim.Play();

		//Trex Object
		trexStay.SetActive(false);
		trexWalk.SetActive(false);
		trexRun.SetActive(false);
		trexHunt.SetActive(true);
	}

	public void SceneWalk()
	{

		jungleAnim["Jungle"].speed = walkSpeed;
		this.jungleAnim.Play();

		openareaAnim["OpenArea"].speed = walkSpeed;
		this.openareaAnim.Play();

		desertAnim["Desert"].speed = walkSpeed;
		this.desertAnim.Play();

		//Trex Object
		trexStay.SetActive(false);
		trexWalk.SetActive(true);
		trexRun.SetActive(false);
		trexHunt.SetActive(false);
	}

	public void SceneRun()
	{
		runAnim["DinoRun"].speed = trexrunSpeed;

		jungleAnim["Jungle"].speed = runSpeed;
		this.jungleAnim.Play();

		openareaAnim["OpenArea"].speed = runSpeed;
		this.openareaAnim.Play();

		desertAnim["Desert"].speed = runSpeed;
		this.desertAnim.Play();

		//Trex Object
		trexStay.SetActive(false);
		trexWalk.SetActive(false);
		trexRun.SetActive(true);
		trexHunt.SetActive(false);
	}

	public void JungleScene()
	{
		jungleTreadmill.SetActive(true);
		openareaTreadmill.SetActive(false);
		desertTreadmill.SetActive(false);
	}

	public void OpenAreaScene()
	{
		jungleTreadmill.SetActive(false);
		openareaTreadmill.SetActive(true);
		desertTreadmill.SetActive(false);
	}

	public void DesertScene()
	{
		jungleTreadmill.SetActive(false);
		openareaTreadmill.SetActive(false);
		desertTreadmill.SetActive(true);
	}

	public void OpenInfo()
	{
		InfoPanel.SetActive(true);
	}

	public void CloseInfo()
	{
		InfoPanel.SetActive(false);
	}

}
