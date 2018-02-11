using UnityEngine;
using System.Collections;

public class DialogueManager3 : MonoBehaviour
{
  public GameObject dialogue;
  public GameObject tvSpeakers;
  public GameObject popUp;
  public GameObject boyTrigger;
  public GameObject approachTrigger;
  public GameObject dialogueFinished;

  public GameObject shrineTrigger;
  public GameObject popUpShrine;
  public GameObject tvInteraction;
  public GameObject tvTrigger;

  void Update()
    {
      if(approachTrigger.activeSelf)
        {
          tvSpeakers.SetActive(true);

          if(boyTrigger.activeSelf && Input.GetKeyDown(KeyCode.E))
            {
              dialogue.SetActive(true);
            }
        }
      if(tvTrigger.activeSelf)
        {
          tvInteraction.SetActive(true);
        } else {
          tvInteraction.SetActive(false);
        }
    }

  void OnTriggerEnter(Collider coll)
    {
      if(coll.tag == "TeenKid")
        {
          approachTrigger.SetActive(true);
          if(!dialogueFinished.activeSelf)
            {
              popUp.SetActive(true);
            }
        }

      if(coll.tag == "Shrine" && shrineTrigger.activeSelf)
        {
          popUpShrine.SetActive(true);
        }
    }

  void OnTriggerExit(Collider coll)
    {
      if(coll.tag == "TeenKid")
        {
          approachTrigger.SetActive(false);
          popUp.SetActive(false);
        }

      if(coll.tag == "Shrine")
        {
          popUpShrine.SetActive(false);
        }
    }
}
