using UnityEngine;
using System.Collections;

public class DialogueManager4 : MonoBehaviour
{
  public GameObject dialogue;
  public GameObject popUp;
  public GameObject kidTrigger;

  public GameObject shrineTrigger;
  public GameObject popUpShrine;
  public GameObject dialogueLoveShrine;

  public GameObject kid2Trigger;
  public GameObject kidInteraction;
  public GameObject interactionButton;
  public GameObject approachKid;

  void Update()
    {
      if(popUp.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
          dialogue.SetActive(true);
        }

      if(popUpShrine.activeSelf)
        {
          Debug.Log("dialogue");
          dialogueLoveShrine.SetActive(true);
        }

      if(approachKid.activeSelf)
        {
          kidInteraction.SetActive(true);
        } else {
          kidInteraction.SetActive(false);
        }

    }

  void OnTriggerEnter(Collider coll)
    {
      if(coll.tag == "AdultKid")
        {
          if(kidTrigger.activeSelf)
            {
              popUp.SetActive(true);
            }
          if(kid2Trigger.activeSelf)
            {
              approachKid.SetActive(true);
            }
        }

      if(coll.tag == "Shrine" && shrineTrigger.activeSelf)
        {
          popUpShrine.SetActive(true);
        }
    }

  void OnTriggerExit(Collider coll)
    {
      if(coll.tag == "AdultKid")
        {
          Debug.Log("out of approach");
          approachKid.SetActive(false);
          popUp.SetActive(false);
        }
      
      if(coll.tag == "Shrine")
        {
          popUpShrine.SetActive(false);
        }
    }
}