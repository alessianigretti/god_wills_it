using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour
{
	bool inDoor;
	public GameObject popUp;
    public Vector3 newLocation;
	
    void OnTriggerEnter (Collider coll)
    {
		if (coll.tag == "Player") 
		{
			inDoor = true;
			popUp.SetActive(true);
		}
	}

	void OnTriggerExit (Collider coll)
    {
		inDoor = false;
		popUp.SetActive (false);
	}

	void Update ()
    {
		if (inDoor && Input.GetKeyDown (KeyCode.E))
		{
            GameObject player = GameObject.FindGameObjectWithTag ("Player");
		    player.transform.position = newLocation;
		}
	}
}
