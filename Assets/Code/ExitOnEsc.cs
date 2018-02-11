using UnityEngine;
using System.Collections;

public class ExitOnEsc : MonoBehaviour
{
    void Start()
    {
      if(Input.GetKeyDown(KeyCode.Escape))
        {
          Application.Quit();
        }
	}
}
