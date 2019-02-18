using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour {

	public GameObject jawInfo, femurInfo, tailInfo;

	public GameObject level3Info;

	public void Home()
	{
		SceneManager.LoadScene("Home");
	}

	public void Setting()
	{
		SceneManager.LoadScene("Setting");
	}

	public void JawInfoClose()
	{
		jawInfo.SetActive(false);
	}

	public void FemurInfoClose()
	{
		femurInfo.SetActive(false);
	}

	public void TailInfoClose()
	{
		tailInfo.SetActive(false);
	}

	public void InfoOpen()
	{
		level3Info.SetActive(true);
	}

	public void InfoClose()
	{
		level3Info.SetActive(false);
	}
}
