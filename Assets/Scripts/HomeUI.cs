using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeUI : MonoBehaviour {

	public GameObject HomePanel;
	public GameObject GamePanel;

	private void Start()
	{
		GamePanel.SetActive(false);
	}

	public void Level1()
	{
		SceneManager.LoadScene("Level1_SelfieSelection");
	}

	public void Level2()
	{
		SceneManager.LoadScene("Level2");
	}

	public void Level3()
	{
		SceneManager.LoadScene("Level3");
	}

	public void PressStart()
	{
		HomePanel.SetActive(false);
		GamePanel.SetActive(true);
	}

	public void PressSetting()
	{
		SceneManager.LoadScene("Setting");
	}

	public void PressQuit()
	{
		Application.Quit();
	}

	public void PressBack()
	{
		GamePanel.SetActive(false);
		HomePanel.SetActive(true);
	}
}
