using UnityEngine;
using System.Collections;

public class ChangeRoomScript : MonoBehaviour {

    public GameObject notification;

	// Use this for initialization
	void OnTriggerEnter2D () {

        notification.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
