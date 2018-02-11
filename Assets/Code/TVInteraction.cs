using UnityEngine;
using System.Collections;

public class TVInteraction : MonoBehaviour
{
  public GameObject tvTrigger;
  public GameObject approachTrigger;
  public GameObject interactionButton;

  public GameObject watchChoice;
  public GameObject watchAudio;
  public GameObject player;
  public GameObject fadeTrigger;

  public GameObject switchChoice;
  public GameObject tvScreen;
  public GameObject dialogueTVSwitch;

  void Update()
    {
      if(tvTrigger.activeSelf && approachTrigger.activeSelf)
        {
          Debug.Log("approach");
          interactionButton.SetActive(true);

          if(interactionButton.activeSelf)
            {
              if(Input.GetKeyDown(KeyCode.X))
                {
                  watchChoice.SetActive(true);
                  player.GetComponent<PlayerControllerScript>().enabled = false;
                  watchAudio.SetActive(true);
                  Destroy(interactionButton);
                  fadeTrigger.SetActive(true);
                }
              if(Input.GetKeyDown(KeyCode.C))
                {
                  switchChoice.SetActive(true);
                  tvScreen.SetActive(true);
                  dialogueTVSwitch.SetActive(true);
                  Destroy(interactionButton);
                }
            }
        } else {
          Debug.Log("no approach");
          interactionButton.SetActive(false);
        }
    }
}
