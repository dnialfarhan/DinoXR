using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour {

	private List<GameObject> dinos;

	private int selectionIndex = 0;

	private void Start()
	{
		Screen.orientation = ScreenOrientation.Landscape;
		dinos = new List<GameObject>();
		foreach (Transform t in transform)
		{
			dinos.Add(t.gameObject);
			t.gameObject.SetActive(false);
		}

		dinos[selectionIndex].SetActive(true);
	}

	public void DinoSelect(int index)
	{
		if(index == selectionIndex)
			return;
		
		if(index <0 || index>= dinos.Count)
			return;

		dinos[selectionIndex].SetActive(false);
		selectionIndex = index;
		dinos[selectionIndex].SetActive(true);
	}

	public void SelectTrex()
	{
		SceneManager.LoadScene("Level1_SelfieScene");
	}
}
