using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueLove : MonoBehaviour
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
      if(currentLine == 68 || currentLine == 70)
        {
          greenText.enabled = false;
          blueText.enabled = true;
          blueText.text = textLines[currentLine];
        } else if(currentLine == 69 || currentLine == 71 || currentLine == 72) {
          blueText.enabled = false;
          greenText.enabled = true;
          greenText.text = textLines[currentLine];
        }

      if(currentLine == 72)
        {
          kidTrigger.SetActive(false);
          cameraShrineTrigger.SetActive(true);
          dialogue.SetActive(false);
          currentLine++;
        }

      if(Input.GetKeyDown(KeyCode.E) && popUp.activeSelf && currentLine != 72)
        {
          currentLine++;
        }

      if(currentLine > endAtLine)
        {
          textBox.SetActive(false);
        }
    }
}
