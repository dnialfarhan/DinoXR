using UnityEngine;
using UnityEngine.Playables;

public class Test : MonoBehaviour
{

	public PlayableDirector anim;

	// Update is called once per frame
	void Update()
	{

		if (Input.touchCount > 0)
		{
			var ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo))
			{

				if (hitInfo.collider.tag == "Test")
				{
					anim.Play();
				}

			}
		}
	}
}
