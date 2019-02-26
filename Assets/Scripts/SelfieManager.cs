using UnityEngine;
using UnityEngine.SceneManagement;

public class SelfieManager : MonoBehaviour {

	public void Start()
	{
		Screen.orientation = ScreenOrientation.Portrait;
	}

	public void BackCharacterSelection()
	{
		SceneManager.LoadScene("Level1_SelfieSelection");
	}

	public void ReturnMenu()
	{
		SceneManager.LoadScene("Home");
	}
}
