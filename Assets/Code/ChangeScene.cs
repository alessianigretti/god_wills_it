using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

  public GameObject fadeTrigger;

  void Update()
    {
      StartCoroutine(Delay());
      fadeTrigger.SetActive(true);
    }

  IEnumerator Delay()
    {
      yield return new WaitForSeconds(3);
    }
}
