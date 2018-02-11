using UnityEngine;
using System.Collections;

public class AfterSceneFour : MonoBehaviour
{
  public GameObject oldPlayer;
  public GameObject newPlayer;
  public GameObject oldPlayerPraying;
  public GameObject newPlayerPraying;
  public GameObject oldAdultKid;
  public GameObject newAdultKid;
  public GameObject boyfriend;
  public GameObject kidPopUp;
  public GameObject kidTrigger;

  public Light[] houseLights;
  public Light[] shrineLights;

  public GameObject beYouChoice;
  public GameObject conformChoice;

  public GameObject watchChoice;
  public GameObject switchChoice;

  public GameObject listenChoice;
  public GameObject destroyChoice;

  public GameObject holyChoice;
  public GameObject scienceChoice;

  public GameObject paintingGroup1Ground;
  public GameObject paintingGroup1Middle;
  public GameObject paintingGroup1Bathroom;
  public GameObject paintingGroup1Kids;
  public GameObject paintingGroup1Shrine;

  public GameObject paintingGroup2Ground;
  public GameObject paintingGroup2Middle;
  public GameObject paintingGroup2Bathroom;
  public GameObject paintingGroup2Kids;

  public GameObject paintingGroup3Kids;

  public GameObject pastFader;
  public GameObject pastCameraFocus;

  void Start()
    {
      Destroy(oldPlayer);
      Destroy(oldPlayerPraying);
      newPlayerPraying.SetActive(true);
      Destroy(oldAdultKid);
      newAdultKid.SetActive(true);
      boyfriend.SetActive(true);
      kidTrigger.SetActive(true);
      Destroy(kidPopUp);
      Destroy(pastFader);
      Destroy(pastCameraFocus);

      foreach(Light light in houseLights)
        {
          if(conformChoice.activeSelf)
            {
              light.intensity -= 1;
            }
        }

      foreach(Light light in shrineLights)
        {
          if(conformChoice.activeSelf)
            {
              light.intensity += 5;
          } else if(beYouChoice.activeSelf)
            {
              light.intensity -= 2;
            }
        }

      if (switchChoice.activeSelf && destroyChoice.activeSelf && holyChoice.activeSelf)
        {
          paintingGroup3Kids.SetActive (true);
      } else if((switchChoice.activeSelf && destroyChoice.activeSelf) || (destroyChoice.activeSelf && holyChoice.activeSelf) || (switchChoice.activeSelf && holyChoice.activeSelf)) 
        {
          paintingGroup2Ground.SetActive(true);
          paintingGroup2Middle.SetActive(true);
          paintingGroup2Bathroom.SetActive(true);
          paintingGroup2Kids.SetActive(true);
      } else if(switchChoice.activeSelf)
        {
          paintingGroup1Shrine.SetActive (true);
          paintingGroup1Ground.SetActive (true);
          paintingGroup1Middle.SetActive (true);
          paintingGroup1Bathroom.SetActive (true);
          paintingGroup1Kids.SetActive (true);
        }
    }	
}
