using UnityEngine;

public class FossilRaycast : MonoBehaviour {

	//Wireframe Fossil 
	public GameObject jawWire, femurWire, tailWire;
	//Real Fossil
	public GameObject jawReal, femurReal, tailReal;

	//Button To Convert Dinosour
	public GameObject convertDino;

	//Replace Fossil to Real Dinosaur
	public GameObject realDino;
	public GameObject fossilDino;
	public Animation realDinoAnim;

	//Excavation Animation
	public Animation jawSoil, femurSoil, tailSoil;

	//Placer Button
	public GameObject jawBttn, femurBttn, tailBttn;


	void FixedUpdate()
	{

		if (Input.touchCount > 0)
		{
			var ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo))
			{

				if (hitInfo.collider.tag == "JawButton")
				{
					jawWire.SetActive(false);
					jawReal.SetActive(true);
					jawBttn.SetActive(false);
				}

				if (hitInfo.collider.tag == "FemurButton")
				{
					femurWire.SetActive(false);
					femurReal.SetActive(true);
					femurBttn.SetActive(false);
				}

				if (hitInfo.collider.tag == "TailButton")
				{
					tailWire.SetActive(false);
					tailReal.SetActive(true);
					tailBttn.SetActive(false);
				}

				if (jawReal.activeInHierarchy == true && femurReal.activeInHierarchy == true 
					&& tailReal.activeInHierarchy == true)
				{
					convertDino.SetActive(true);
				}

				if(hitInfo.collider.tag == "ConvertDino")
				{
					fossilDino.SetActive(false);
					realDino.SetActive(true);
					realDinoAnim.Play();

				}

				if(hitInfo.collider.tag == "ExcavationBoxJaw")
				{
					jawSoil.Play();
				}

				if (hitInfo.collider.tag == "ExcavationBoxFemur")
				{
					femurSoil.Play();
				}

				if (hitInfo.collider.tag == "ExcavationBoxTail")
				{
					tailSoil.Play();
				}

			}
		}
	}
}
