using UnityEngine;
using System.Collections;

public class PlayerPrayExit : MonoBehaviour
{
	public GameObject praying;
	public GameObject player;
	public GameObject shrineTrigger;
	public GameObject dialogue;
	public GameObject popUp;

	void Start()
	{
		praying.SetActive(true);
		player.SetActive(false);
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
		{
			praying.SetActive(false);
			player.SetActive(true);
		}

		if(praying.activeSelf && shrineTrigger.activeSelf)
		{
			popUp.SetActive(true);

			if(Input.GetKeyDown(KeyCode.E))
			{
				dialogue.SetActive(true);
			}
		} else {
			dialogue.SetActive(false);
		}
	}
}
