using UnityEngine;
using System.Collections;

public class AfterSceneOne : MonoBehaviour
{
  public GameObject oldPlayer;
  public GameObject newPlayer;
  public GameObject oldPlayerPraying;
  public GameObject newPlayerPraying;
  public GameObject childKid;
  public GameObject teenKid;
  public GameObject teddyBear1;
  public GameObject teddyBear2;
  public GameObject teddyBear3;
  public GameObject kidPopUp;

  public Light[] houseLights;
  public Light[] shrineLights;

  public GameObject holyChoice;
  public GameObject scienceChoice;

  public GameObject paintingGroup1Shrine;
  public GameObject paintingGroup1Ground;
  public GameObject paintingGroup1Middle;
  public GameObject paintingGroup1Bathroom;
  public GameObject paintingGroup1Kids;

  public GameObject pastDialogue;
  public GameObject fadeTrigger;
    
  	void Start ()
    {
      Destroy(oldPlayer);
      Destroy(oldPlayerPraying);
      newPlayerPraying.SetActive(true);
      Destroy(childKid);
      teenKid.SetActive(true);
      Destroy(teddyBear1);
      Destroy(teddyBear2);
      Destroy(teddyBear3);
      Destroy(kidPopUp);
      pastDialogue.SetActive(false);
      Destroy(fadeTrigger);


      foreach(Light light in houseLights)
      {
          if(holyChoice.activeSelf)
            {
                light.intensity -= 1;
            }
      }

      foreach(Light light in shrineLights)
      {
          if(holyChoice.activeSelf)
            {
              light.intensity += 5;
          } else if(scienceChoice.activeSelf)
            {
              light.intensity -= 2;
            }
      }

      if(holyChoice.activeSelf)
        {
          paintingGroup1Shrine.SetActive(true);
          paintingGroup1Ground.SetActive(true);
          paintingGroup1Middle.SetActive(true);
          paintingGroup1Bathroom.SetActive(true);
          paintingGroup1Kids.SetActive(true);
        }
	}
}
