using UnityEngine;
using System.Collections;

public class WebCam1 : MonoBehaviour
{
	public int Width = 1280;
	public int Height = 480;
	public int FPS = 30;
	
	//public int cameraNumber = 0;
	private WebCamTexture webcamTexture;
	
	// Use this for initialization
	void Start()
	{
		WebCamDevice[] devices = WebCamTexture.devices;
		//print (devices.Length);
		print (devices[0].name);
		if (devices.Length > 0) {
			webcamTexture = new WebCamTexture(devices[0].name, Width, Height, FPS);
			renderer.material.mainTexture = webcamTexture;
			webcamTexture.Play();
		} else {
			Debug.Log("no camera");
		}
	}
	
	// Update is called once per frame
	void Update()
	{
		
	}
}