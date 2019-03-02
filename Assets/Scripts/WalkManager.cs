using UnityEngine;
using UnityEngine.SceneManagement;

public class WalkManager : MonoBehaviour {

	public GameObject ScenePanel, DinoPanel, AnimationPanel;

	[SerializeField]
	private AnimationManager animManager;

	[SerializeField]
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
	}

	public void SelectWalk()
	{
		animManager.SceneWalk();
	}

	public void SelectRun()
	{
		animManager.SceneRun();
	}

	public void SelectJungle()
	{
		animManager.JungleScene();
	}

	public void SelectOpenArea()
	{
		animManager.OpenAreaScene();
	}

	public void SelectDesert()
	{
		animManager.DesertScene();
	}

}
