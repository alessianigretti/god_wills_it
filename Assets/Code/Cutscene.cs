using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
  public GameObject staticAudio;

  void Start()
    {
      staticAudio.SetActive(true);
      StartCoroutine(Delay());
      SceneManager.LoadScene("Cutscene");
	}

  IEnumerator Delay()
    {
      yield return new WaitForSeconds(7);
    }
}
