using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueMusicShrine : MonoBehaviour
{
  public GameObject textBox;

  public Text goldText;
  public Text greenText;

  public TextAsset textFile;
  public string[] textLines;

  public int currentLine;
  public int endAtLine;

  public GameObject player;

  public GameObject shrineTrigger;
  public GameObject dialogueMusicShrine;
  public GameObject jukeboxTrigger;

  void Start()
    {
     if(textFile != null)
        {
          textLines = (textFile.text.Split('\n'));
        }

      if(endAtLine == 0)
        {
          endAtLine = textLines.Length - 1;
        }
    }

  void Update()
    {
       if(currentLine == 35)
             {
              goldText.enabled = false;
              greenText.enabled = true;
              greenText.text = textLines[currentLine];
             } else {
              greenText.enabled = false;
              goldText.enabled = true;
              goldText.text = textLines[currentLine];
             }
 
      if(currentLine == 41)
        {
          shrineTrigger.SetActive(false);
          dialogueMusicShrine.SetActive(false);
          jukeboxTrigger.SetActive(true);
          Debug.Log("jukeboxtrigger");
        }

      if(Input.GetKeyDown(KeyCode.E) && currentLine != 41)
        {
          currentLine++;
        }

      if(currentLine > endAtLine)
        {
          textBox.SetActive(false);
        }
    }
}