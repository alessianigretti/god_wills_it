using UnityEngine;
using System.Collections;

public class PixelPerfect : MonoBehaviour {

	// Assign the camera this affects via the inspector.
	public Camera camera;

	void Update() 
	{
		float height = Screen.height;

		camera.orthographicSize = (height / 2) / 100;
	}
	
}
