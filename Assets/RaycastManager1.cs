using UnityEngine;
using UnityEngine.UI;


public class RaycastManager1 : MonoBehaviour
{

	public Image Fossil;

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
					var fossilColor = Fossil.color;
					fossilColor.a = 1f;
					Fossil.color = fossilColor;
				}
			}

		}
	}
}
