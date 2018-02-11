using UnityEngine;
using System.Collections;

public class KidInteraction : MonoBehaviour
{
  public GameObject approachTrigger4;
  public GameObject interactionButton;

  public GameObject beYouChoice;
  public GameObject conformChoice;

  public GameObject dialogueLoveBeYouChoice;
  public GameObject dialogueLoveConformChoice;

  public GameObject kidInteraction;
  public GameObject approachKid;

	void Update()
    {
      if(kidInteraction.activeSelf && approachKid.activeSelf)
        {
          interactionButton.SetActive(true);

          if(interactionButton.activeSelf)
            {
               if(Input.GetKeyDown(KeyCode.X))
                {
                      beYouChoice.SetActive(true);
                   dialogueLoveBeYouChoice.SetActive(true);
                   Destroy(interactionButton);
                      kidInteraction.SetActive(false);
                  }
             if(Input.GetKeyDown(KeyCode.C))
               {
                  conformChoice.SetActive(true);
                  dialogueLoveConformChoice.SetActive(true);
                  Destroy(interactionButton);
                  kidInteraction.SetActive(false);
              }
            }
        } else {
          interactionButton.SetActive(false);
        }
	}
}
