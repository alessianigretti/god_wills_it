using UnityEngine;
using System.Collections;

public class DialogueManager : MonoBehaviour {

  public GameObject shrineTrigger;
  public GameObject dialogue;
  public GameObject dialogueTelevision;
  public GameObject popUp;
  public GameObject teenKid;

  void Update()
    {
      if(popUp.activeSelf)
        {
          if(Input.GetKeyDown(KeyCode.E))
            {
              dialogue.SetActive(true);
            }

          if(teenKid.activeSelf)
            {
              dialogueTelevision.SetActive(true);
            }
        } else {
          dialogue.SetActive(false);
          dialogueTelevision.SetActive(false);
        }
          
    }

  void OnTriggerEnter(Collider coll)
    {
      if(coll.tag == "Shrine" && shrineTrigger.activeSelf)
        {
          popUp.SetActive(true);
        } else {
          popUp.SetActive(false);
        }
    }

  void OnTriggerExit(Collider coll)
    {
      if(coll.tag == "Shrine")
        {
          popUp.SetActive(false);
        }
    }
}
