using UnityEngine;

public class PlacerManager_Level3 : MonoBehaviour {


	public GameObject placeFossil;
	public GameObject excavatedFossil;

	private void Start()
	{
		placeFossil.SetActive(false);
	}

	void OnTriggerEnter(Collider other)
	{
		if(excavatedFossil.activeInHierarchy == false)
		{
			if (other.gameObject.tag == "MainCamera")
			{
				placeFossil.SetActive(true);
			}
		}
	}

	 void OnTriggerExit(Collider other)
	{
		placeFossil.SetActive(false);
	}

}
