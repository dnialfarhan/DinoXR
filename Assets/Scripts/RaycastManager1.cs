using UnityEngine;
using UnityEngine.UI;

public class RaycastManager1 : MonoBehaviour
{
	public Button jawFossil, femurFossil, tailFossil, ammoniteFossil, elmFossil;
	public GameObject jawUI, femurUI, tailUI, ammoniteUI, elmUI;

	void FixedUpdate()
	{
	
		if (Input.touchCount > 0)
		{
			var ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo))
			{

				if (hitInfo.collider.tag == "Femur")
				{
					femurFossil.interactable = true;
					femurUI.SetActive(true);
					hitInfo.collider.gameObject.SetActive(false);
				}

				if (hitInfo.collider.tag == "Jaw")
				{
					jawFossil.interactable = true;
					jawUI.SetActive(true);
					hitInfo.collider.gameObject.SetActive(false);
				}

				if (hitInfo.collider.tag == "Tail")
				{
					tailFossil.interactable = true;
					tailUI.SetActive(true);
					hitInfo.collider.gameObject.SetActive(false);
				}

				if (hitInfo.collider.tag == "Ammonite")
				{
					ammoniteFossil.interactable = true;
					ammoniteUI.SetActive(true);
					hitInfo.collider.gameObject.SetActive(false);
				}

				if(hitInfo.collider.tag == "Elm")
				{
					elmFossil.interactable = true;
					elmUI.SetActive(true);
					hitInfo.collider.gameObject.SetActive(false);
				}
			}

		}

	}
}
