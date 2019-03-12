using System.Collections;
using UnityEngine;


public class TakeScreenshot : MonoBehaviour {

	[SerializeField]
	GameObject blink;
	public Canvas canvasUI;
	public AudioSource shutter;

	public void TakeAShot()
	{
		StartCoroutine ("CaptureIt");
	}

	IEnumerator CaptureIt()
	{
		canvasUI.enabled = false;
		string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
		string fileName = "Screenshot" + timeStamp + ".png";
		string pathToSave = fileName;
		ScreenCapture.CaptureScreenshot(pathToSave);
		//yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		canvasUI.enabled = true;
		blink.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		blink.SetActive(false);
		shutter.Play();
	
	}

	

}
