using UnityEngine;
using System.Collections;

public class JukeboxColl : MonoBehaviour
{
  public GameObject jukeboxTrigg;
  public GameObject popUp;

  public GameObject jukebox;
  public GameObject destroyedJukebox;

  public GameObject audioJukebox;

  public GameObject destroyChoice;
  public GameObject listenChoice;

  public GameObject changeScene;

  void Update()
    {
      if(popUp.activeSelf)
        {
          if(Input.GetKeyDown(KeyCode.X))
            {
              destroyChoice.SetActive(true);
              changeScene.SetActive(true);
              jukebox.SetActive(false);
              destroyedJukebox.SetActive(true);
            }

          if(Input.GetKeyDown(KeyCode.C))
            {
              listenChoice.SetActive(true);
              changeScene.SetActive(true);
              audioJukebox.SetActive(true);
              Destroy(popUp);
            }
        }
    }

  void OnTriggerEnter(Collider coll)
    {
      if(coll.tag == "Player" && jukeboxTrigg.activeSelf)
        {
          popUp.SetActive(true);
        }
    }

  void OnTriggerExit(Collider coll)
    {
      if(coll.tag == "Player")
        {
          popUp.SetActive(false);
        }
    }
}