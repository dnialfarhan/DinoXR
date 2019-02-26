using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WalkManager : MonoBehaviour {

	public void ReturnMenu()
	{
		SceneManager.LoadScene("Home");
	}
}
