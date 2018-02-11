using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OnKeyPress : MonoBehaviour
{
  public GameObject background;
  public GameObject gM;
  void Start()
    {
      background.SetActive(true);
    }
  
  void Update()
    {
      ChangeScene();
    }
  
  void ChangeScene()
    {
      if (Input.anyKey)
        {
          SceneManager.LoadScene(1);
        }
    }
}