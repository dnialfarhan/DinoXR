using UnityEngine;

public class PlacerManager_Level3 : MonoBehaviour {


	public GameObject placeFossil;

	private void Start()
	{
		placeFossil.SetActive(false);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "MainCamera")
		{
			placeFossil.SetActive(true);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		placeFossil.SetActive(false);
	}

}
