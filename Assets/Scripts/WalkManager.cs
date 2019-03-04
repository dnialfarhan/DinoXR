using UnityEngine;
using UnityEngine.SceneManagement;

public class WalkManager : MonoBehaviour {

	public GameObject ScenePanel, DinoPanel, AnimationPanel;

	private AnimationManager animManager;

	private GameObject instantiateObject;

	private void Start()
	{
		ScenePanel.SetActive(false);
		DinoPanel.SetActive(false);
		AnimationPanel.SetActive(false);
	}

	private void Update()
	{
		instantiateObject = GameObject.FindGameObjectWithTag("Dino");

		if(instantiateObject != null)
		{
			animManager = instantiateObject.GetComponent<AnimationManager>();
		}
	}

	public void ReturnMenu()
	{
		SceneManager.LoadScene("Home");
	}

	public void Setting()
	{
		SceneManager.LoadScene("Setting");
	}

	public void ExpandScene()
	{
		ScenePanel.SetActive(true);
		DinoPanel.SetActive(false);
		AnimationPanel.SetActive(false);
	}

	public void ExpandDino()
	{
		DinoPanel.SetActive(true);
		ScenePanel.SetActive(false);
		AnimationPanel.SetActive(false);
	}

	public void ExpandAnim()
	{
		AnimationPanel.SetActive(true);
		DinoPanel.SetActive(false);
		ScenePanel.SetActive(false);
	}

	public void SelectIdle()
	{
		animManager.SceneIdle();
		AnimationPanel.SetActive(false);
	}

	public void SelectWalk()
	{
		animManager.SceneWalk();
		AnimationPanel.SetActive(false);
	}

	public void SelectRun()
	{
		animManager.SceneRun();
		AnimationPanel.SetActive(false);
	}

	public void SelectJungle()
	{
		animManager.JungleScene();
		ScenePanel.SetActive(false);
	}

	public void SelectOpenArea()
	{
		animManager.OpenAreaScene();
		ScenePanel.SetActive(false);
	}

	public void SelectDesert()
	{
		animManager.DesertScene();
		ScenePanel.SetActive(false);
	}

	public void SelectTrex()
	{
		DinoPanel.SetActive(false);
	}

	public void SelectInfo()
	{
		if(animManager.InfoPanel.activeInHierarchy == false)
		{
			animManager.OpenInfo();
		}else

		if (animManager.InfoPanel.activeInHierarchy == true)
		{
			animManager.CloseInfo();
		}
	}

}
