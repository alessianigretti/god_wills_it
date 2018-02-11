using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueBFConform : MonoBehaviour
{
  public GameObject textBox;

  public Text blueText;

  public TextAsset textFile;
  public string[] textLines;

  public int currentLine;
  public int endAtLine;

  public GameObject player;

  public GameObject cameraShrineTrigger;
  public GameObject dialogue;
  public GameObject kidTrigger;
  public GameObject popUp;

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
          blueText.enabled = true;
          blueText.text = textLines[currentLine];

      if(currentLine == 103) //99-103
        {
          cameraShrineTrigger.SetActive(true);
          kidTrigger.SetActive(false);
          dialogue.SetActive(false);
        }

      if(Input.GetKeyDown(KeyCode.E) && popUp.activeSelf && currentLine != 103)
        {
          currentLine++;
        }

      if(currentLine > endAtLine)
        {
          textBox.SetActive(false);
        }
    }
}
