using UnityEngine;

public class RaycastTest : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton(0))
		{
			var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo))
			{
				if(hitInfo.collider.tag == "Femur")
				{
					Debug.Log("Femur!");
				}

				if (hitInfo.collider.tag == "Jaw")
				{
					Debug.Log("Jaw!");
				}

				if (hitInfo.collider.tag == "Tail")
				{
					Debug.Log("Tail!");
				}
			}
		}

	}
}
