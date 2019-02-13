using UnityEngine;
using UnityEngine.UI;
using GoogleARCore.Examples.HelloAR;

public class RaycastManager1 : MonoBehaviour
{
	public Button jawFossil, femurFossil, tailFossil;
	public GameObject jawUI, femurUI, tailUI;


	void Update()
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
					//Destroy(hitInfo.collider.gameObject);
					hitInfo.collider.gameObject.SetActive(false);
				}

				if (hitInfo.collider.tag == "Jaw")
				{
					jawFossil.interactable = true;
					jawUI.SetActive(true);
					//Destroy(hitInfo.collider.gameObject);
					hitInfo.collider.gameObject.SetActive(false);
				}

				if (hitInfo.collider.tag == "Tail")
				{
					tailFossil.interactable = true;
					tailUI.SetActive(true);
					//Destroy(hitInfo.collider.gameObject);
					hitInfo.collider.gameObject.SetActive(false);
				}


			}

		}
	}
}
