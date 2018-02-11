using UnityEngine;
using System.Collections;

public class PlayerPray : MonoBehaviour
{
	private bool approach;
	public GameObject praying;
	public GameObject player;

	void Start()
	{
		approach = false;
		praying.SetActive(false);
		player.SetActive(true);
	}

	void Update()
	{
		if(approach)
		{
			if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
			{
				praying.SetActive(true);
				player.SetActive(false);
			}
		}
	}

	void OnTriggerEnter(Collider coll)
	{
		if(coll.tag == "Shrine")
		{
			approach = true;
			Debug.Log("approach");
		}
	}

	void OnTriggerExit(Collider coll)
	{
		if(coll.tag == "Shrine")
		{
			approach = false;
			Debug.Log("approachExit");
		}
	}
}
