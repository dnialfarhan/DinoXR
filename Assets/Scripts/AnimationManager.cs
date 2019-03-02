using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

	//Treadmill Object
	public GameObject jungleTreadmill, openareaTreadmill, desertTreadmill;

	//Treadmill Animation
	public Animation jungleAnim, openareaAnim, desertAnim;

	//Animation Speed
	public float idleSpeed;
	public float walkSpeed;
	public float runSpeed;

	public void SceneIdle()
	{
		jungleAnim["Jungle"].speed = idleSpeed;
		openareaAnim["OpenArea"].speed = idleSpeed;
		desertAnim["Desert"].speed = idleSpeed;
		Debug.Log("Idle Pressed");

		jungleAnim.Play();
		openareaAnim.Play();
		desertAnim.Play();
	}

	public void SceneWalk()
	{
		jungleAnim["Jungle"].speed = walkSpeed;
		openareaAnim["OpenArea"].speed = walkSpeed;
		desertAnim["Desert"].speed = walkSpeed;
		Debug.Log("Walk Pressed");

		jungleAnim.Play();
		openareaAnim.Play();
		desertAnim.Play();
	}

	public void SceneRun()
	{
		jungleAnim["Jungle"].speed = runSpeed;
		openareaAnim["OpenArea"].speed = runSpeed;
		desertAnim["Desert"].speed = runSpeed;
		Debug.Log("Run Pressed");

		jungleAnim.Play();
		openareaAnim.Play();
		desertAnim.Play();
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



}
