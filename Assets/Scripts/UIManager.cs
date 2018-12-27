using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public GameObject bgChild;
	public GameObject dinoChild;
	public GameObject animChild;
	public GameObject info;

	private void Start()
	{
		bgChild.SetActive(false);
		dinoChild.SetActive(false);
		animChild.SetActive(false);


		info.SetActive(false);
	}

	public void SelectBG()
	{
		bgChild.SetActive(true);
		dinoChild.SetActive(false);
		animChild.SetActive(false);
	}

	public void SelectDino()
	{
		bgChild.SetActive(false);
		dinoChild.SetActive(true);
		animChild.SetActive(false);
	}

	public void SelectAnim()
	{
		bgChild.SetActive(false);
		dinoChild.SetActive(false);
		animChild.SetActive(true);
	}

	public void Infographic()
	{
		info.SetActive(true);
	}
}
