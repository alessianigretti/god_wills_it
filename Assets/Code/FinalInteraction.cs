using UnityEngine;
using System.Collections;

public class FinalInteraction : MonoBehaviour
{
  public GameObject finalInteraction;
  public GameObject interactionButton;

  public GameObject dialogueBFKickChoice;
  public GameObject kickChoice;
  public GameObject dialogueBFAcceptChoice;
  public GameObject acceptChoice;

  void Update()
    {
      if(finalInteraction.activeSelf)
        {
          if(Input.GetKeyDown(KeyCode.X))
            {
              kickChoice.SetActive(true);
              dialogueBFKickChoice.SetActive(true);
              Destroy(interactionButton);
              finalInteraction.SetActive(false);
              Debug.Log("you pressed x");
            }
          if(Input.GetKeyDown(KeyCode.C))
            {
              acceptChoice.SetActive(true);
              dialogueBFAcceptChoice.SetActive(true);
              Destroy(interactionButton);
              finalInteraction.SetActive(false);
              Debug.Log("you pressed c");
            }
        } else {
    
        }
    }
	
}
