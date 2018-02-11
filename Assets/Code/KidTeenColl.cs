using UnityEngine;
using System.Collections;

public class KidTeenColl : MonoBehaviour
{
  public GameObject dialogue;
  private bool approachKid = false;
  public GameObject popUp;
  public GameObject shrineTrigger;
  public GameObject jukeboxTrigger;

  void Update()
    {
      if(approachKid && Input.GetKeyDown(KeyCode.E))
        {
          dialogue.SetActive(true);
        }
    }

  void OnTriggerEnter(Collider coll)
    {
      if(coll.tag == "TeenKid")
        {
          approachKid = true;
          if(!shrineTrigger.activeSelf && !jukeboxTrigger.activeSelf)
            {
                popUp.SetActive(true);
            } else {
              popUp.SetActive(false);
            }
        }
    }

  void OnTriggerExit(Collider coll)
    {
      if(coll.tag == "TeenKid")
        {
          approachKid = false;
          popUp.SetActive(false);
        }
    }
}
