using UnityEngine;
using System.Collections;

public class DialogueManager5 : MonoBehaviour
{
  public GameObject dialogueBFBeYou;
  public GameObject dialogueBFConform;
  public GameObject popUp;
  public GameObject kidTrigger;
  public GameObject approachTrigger5;

  public GameObject shrineTrigger;
  public GameObject popUpShrine;
  public GameObject dialogueFinalShrine;

  public GameObject kid2Trigger;

  public GameObject beYouChoice;
  public GameObject conformChoice;

  public GameObject finalInteraction;
  public GameObject interactionButton;

  void Update()
    {
      if(popUp.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
          if(beYouChoice.activeSelf)
            {
              dialogueBFBeYou.SetActive(true);
            }
          if(conformChoice.activeSelf)
            {
              dialogueBFConform.SetActive(true);
            }
        }

      if(popUpShrine.activeSelf)
        {
          Debug.Log("dialogue");
          dialogueFinalShrine.SetActive(true);
        }

      if(approachTrigger5.activeSelf)
        {
          finalInteraction.SetActive(true);
          interactionButton.SetActive(true);
        } else {
          finalInteraction.SetActive(false);
          interactionButton.SetActive(false);
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
              approachTrigger5.SetActive(true);
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
          popUp.SetActive(false);
          approachTrigger5.SetActive(false);
        }

      if(coll.tag == "Shrine")
        {
          popUpShrine.SetActive(false);
        }
    }
}