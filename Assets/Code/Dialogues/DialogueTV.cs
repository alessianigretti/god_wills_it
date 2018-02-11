using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueTV : MonoBehaviour
{
  public GameObject textBox;

  public Text blueText;
  public Text greenText;

  public TextAsset textFile;
  public string[] textLines;

  public int currentLine;
  public int endAtLine;

  public GameObject player;

  public GameObject cameraShrineTrigger;
  public GameObject boyTrigger;
  public GameObject approachTrigger;
  public GameObject dialogueFinished;

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
      if(currentLine == 49)
        {
          greenText.enabled = false;
          blueText.enabled = true;
          blueText.text = textLines[currentLine];
        } else if(currentLine == 50 || currentLine == 51) {
          blueText.enabled = false;
          greenText.enabled = true;
          greenText.text = textLines[currentLine];
        }

      if(currentLine == 51)
        {
          cameraShrineTrigger.SetActive(true);
          boyTrigger.SetActive(false);
          dialogueFinished.SetActive(true);
          currentLine++;
        }

      if(Input.GetKeyDown(KeyCode.E) && approachTrigger.activeSelf && currentLine != 52)
        {
          currentLine++;
        }

      if(currentLine > endAtLine)
        {
          textBox.SetActive(false);
        }
    }
}
