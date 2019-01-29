using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour {


	public void Home()
	{
		SceneManager.LoadScene("Home");
	}

	public void Setting()
	{
		SceneManager.LoadScene("Setting");
	}
}
