using UnityEngine;
using System.Collections;

public class WebCamSwitch : MonoBehaviour
{
	public int Width = 1280;
	public int Height = 480;
	public int FPS = 30;
	
	//public int cameraNumber = 0;
	private WebCamTexture webcamTexture;
	
	// Use this for initialization
	void Start()
	{

	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
			WebCam(0);
		}
		else if (Input.GetKeyDown(KeyCode.S))
		{
			WebCam(1);
		}
		else if (Input.GetKeyDown(KeyCode.D))
		{
			WebCam(2);
		}
	}

	void WebCam(int CameraNum)
	{
		WebCamDevice[] devices = WebCamTexture.devices;
		//webcamTexture.Stop();
		print (devices.Length);
		print (devices[CameraNum].name);
		if (devices.Length > 0) {
			webcamTexture = new WebCamTexture(devices[CameraNum].name, Width, Height, FPS);
			renderer.material.mainTexture = webcamTexture;
			if(webcamTexture.isPlaying==true){
				print (webcamTexture.isPlaying);
				webcamTexture.Stop();
			}
			webcamTexture.Play();
		} else {
			Debug.Log("no camera");
		}
	}
}
