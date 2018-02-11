using UnityEngine;
using System.Collections;

public class AfterSceneTwo : MonoBehaviour
{
  public GameObject oldPlayer;
  public GameObject newPlayer;
  public GameObject oldPlayerPraying;
  public GameObject newPlayerPraying;
  public GameObject oldTeenKid;
  public GameObject newTeenKid;
  public GameObject kidPopUp;
  public GameObject television;

  public Light[] houseLights;
  public Light[] shrineLights;

  public GameObject destroyChoice;
  public GameObject listenChoice;

  public GameObject holyChoice;

  public GameObject paintingGroup1Ground;
  public GameObject paintingGroup1Middle;
  public GameObject paintingGroup1Bathroom;
  public GameObject paintingGroup1Kids;
  public GameObject paintingGroup1Shrine;

  public GameObject paintingGroup2Ground;
  public GameObject paintingGroup2Middle;
  public GameObject paintingGroup2Bathroom;
  public GameObject paintingGroup2Kids;

  public GameObject pastFader;
  public GameObject pastCameraFocus;
  public GameObject audioJukebox;

  void Start ()
    {
      Destroy(oldPlayer);
      Destroy(oldPlayerPraying);
      newPlayerPraying.SetActive(true);
      Destroy(oldTeenKid);
      newTeenKid.SetActive(true);
      Destroy(kidPopUp);
      Destroy(pastFader);
      Destroy(pastCameraFocus);
      television.SetActive(false);
      audioJukebox.SetActive(false);

      foreach(Light light in houseLights)
        {
          if(destroyChoice.activeSelf)
            {
              light.intensity -= 1;
            }
        }

      foreach(Light light in shrineLights)
        {
          if(destroyChoice.activeSelf)
            {
              light.intensity += 5;
          } else if(listenChoice.activeSelf)
            {
              light.intensity -= 2;
            }
        }

      if (destroyChoice.activeSelf && holyChoice.activeSelf)
        {
          paintingGroup2Ground.SetActive (true);
          paintingGroup2Middle.SetActive (true);
          paintingGroup2Bathroom.SetActive (true);
          paintingGroup2Kids.SetActive (true);
        } else if(destroyChoice.activeSelf)
        {
          paintingGroup1Shrine.SetActive (true);
          paintingGroup1Ground.SetActive (true);
          paintingGroup1Middle.SetActive (true);
          paintingGroup1Bathroom.SetActive (true);
          paintingGroup1Kids.SetActive (true);
        }
    }
}
