using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCameTexture : MonoBehaviour {
	public int Width = 1920;
	public int Height = 1080;
	public int FPS = 30;

	void Start () {

		//var euler = transform.localRotation.eulerAngles;
		//transform.localRotation = Quaternion.Euler( euler.x, euler.y, euler.z - 90 );

		var devices = WebCamTexture.devices;
		if (devices.Length > 0)
		{
			WebCamTexture webcamTexture = new WebCamTexture(Width, Height, FPS);
			gameObject.GetComponent<Renderer>().material.mainTexture = webcamTexture;
			webcamTexture.Play();
		}else
		{
			Debug.Log("Webカメラが検出できませんでした");
			return;
		}
	}
}
