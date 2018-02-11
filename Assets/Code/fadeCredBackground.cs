
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class fadeCredBackground : MonoBehaviour
{
  public float fadeDuration = 3.0f;
  public bool done = false;
  public RawImage image;
  private void Start ()
    {
      StartCoroutine(StartFading());
    }

  private IEnumerator StartFading()
    {
      yield return StartCoroutine(Fade(0.0f, 1.0f, fadeDuration));
      yield return new WaitForSeconds (30);
      yield return StartCoroutine (Fade (1.0f, 0.0f, fadeDuration));
      yield return new WaitForSeconds (1);
      done = true;
      yield return new WaitForSeconds (1);
    }

  private IEnumerator Fade (float startLevel, float endLevel, float time)
    {
      float speed = 1.0f/time;

      for (float t = 0.0f; t < 1.0; t += Time.deltaTime*speed)
        {
          float a = Mathf.Lerp(startLevel, endLevel, t);
          image.color = new Color(a,
            a,
            a, 255);
          yield return 0;
        }
    }

}