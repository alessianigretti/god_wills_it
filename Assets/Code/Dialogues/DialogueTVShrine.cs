using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueTVShrine : MonoBehaviour
{
  public GameObject textBox;

  public Text goldText;

  public TextAsset textFile;
  public string[] textLines;

  public int currentLine;
  public int endAtLine;

  public GameObject player;

  public GameObject shrineTrigger;
  public GameObject dialogueTVShrine;
  public GameObject tvTrigger;
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
      goldText.enabled = true;
      goldText.text = textLines[currentLine];

      if(currentLine == 61)
        {
          shrineTrigger.SetActive(false);
          dialogueTVShrine.SetActive(false);
          tvTrigger.SetActive(true);
        }

      if(Input.GetKeyDown(KeyCode.E) && currentLine != 61)
        {
          currentLine++;
        }

      if(currentLine > endAtLine)
        {
          textBox.SetActive(false);
        }
    }
}