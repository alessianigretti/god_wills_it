using UnityEngine;
using System.Collections;

public class CameraFocus : MonoBehaviour
{
  public GameObject camera1;
  public GameObject camera2;
  public GameObject cameraShrineTrigger;
  public GameObject shrineGong;
  public GameObject mainTrack;
  public GameObject shrineTrigger;

  void Update()
  {
      if(cameraShrineTrigger.activeSelf)
      {
        shrineGong.SetActive(true);
        camera1.SetActive(false);
        camera2.SetActive(true);
        if(shrineGong.activeSelf)
            {
              mainTrack.SetActive(false);
            } else {
              mainTrack.SetActive(true);
            }
        shrineTrigger.SetActive(true);
        StartCoroutine(Wait());
      }
  }

  IEnumerator Wait()
  {
      yield return new WaitForSeconds(2);
      camera2.SetActive(false);
      camera1.SetActive(true);
      cameraShrineTrigger.SetActive(false);

  }
}
