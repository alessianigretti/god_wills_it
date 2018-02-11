using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueBFShrine : MonoBehaviour
{
  public GameObject textBox;

  public Text goldText;

  public TextAsset textFile;
  public string[] textLines;

  public int currentLine;
  public int endAtLine;

  public GameObject player;

  public GameObject shrineTrigger;
  public GameObject dialogueBFShrine;
  public GameObject kid2Trigger;

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

      if(currentLine == 111) //105-111
        {
          kid2Trigger.SetActive(true);
          shrineTrigger.SetActive(false);
          dialogueBFShrine.SetActive(false);
        }

      if(Input.GetKeyDown(KeyCode.E) && currentLine != 111)
        {
          currentLine++;
        }

      if(currentLine > endAtLine)
        {
          textBox.SetActive(false);
        }
    }
}
