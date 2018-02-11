using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueMusic : MonoBehaviour
{
  public GameObject textBox;

  public Text blueText;
  public Text greenText;

  public TextAsset textFile;
  public string[] textLines;

  public int currentLine;
  public int endAtLine;

  public GameObject player;

  public GameObject shrineTrigger;
  public GameObject cameraShrineTrigger;
  public GameObject audioJukebox;

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
      if(currentLine == 29)
        {
          greenText.enabled = true;
          blueText.enabled = false;
          greenText.text = textLines[currentLine];
        }
      if(currentLine == 30 || currentLine == 31 || currentLine == 32 || currentLine == 33)
          {
            blueText.enabled = true;
            greenText.enabled = false;
            blueText.text = textLines[currentLine];
          }

      if(currentLine == 30)
        {
          audioJukebox.SetActive(true);
        }

      if(currentLine == 33)
        {
          cameraShrineTrigger.SetActive(true);
          currentLine++;
        }

      if(Input.GetKeyDown(KeyCode.E) && currentLine != 33)
        {
          currentLine++;
        }

      if(currentLine > endAtLine)
        {
          textBox.SetActive(false);
        }
    }
}