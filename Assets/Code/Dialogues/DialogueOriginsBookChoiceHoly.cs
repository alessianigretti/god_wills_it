using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueOriginsBookChoiceHoly : MonoBehaviour
{
  public GameObject textBox;

  public Text greenText;

  public TextAsset textFile;
  public string[] textLines;

  public int currentLine;
  public int endAtLine;

  public GameObject player;

  public GameObject holyBookHovering;
  public GameObject scienceBookHovering;
  public GameObject bookshelfTrigger;
  public GameObject fadeTrigger;

  public GameObject holyChoice;
  public GameObject scienceChoice;
  public GameObject dialogue;

  void Start()
    {
      if(holyBookHovering.activeSelf)
        {
          if(textFile != null)
            {
                textLines = (textFile.text.Split('\n'));
                holyChoice.SetActive(true);
            }
      } else if(scienceBookHovering.activeSelf)
        {
          if(textFile != null)
            {
              textLines = (textFile.text.Split('\n'));
              scienceChoice.SetActive(true);
            }
        }

      if(endAtLine == 0)
        {
          endAtLine = textLines.Length - 1;
        }
    }

  void Update()
    {
      greenText.enabled = true;
      greenText.text = textLines[currentLine];
     
      if(currentLine == 19)
        {
          bookshelfTrigger.SetActive(false);
        }

      if(Input.GetKeyDown(KeyCode.E) && currentLine != endAtLine)
        {
          currentLine++;
      } else if(Input.GetKeyDown(KeyCode.E) && currentLine == endAtLine)
        {
          fadeTrigger.SetActive(true);
          dialogue.SetActive(false);
          holyBookHovering.SetActive(false);

        }

      if(currentLine > endAtLine)
        {
          textBox.SetActive(false);
        }
    }
}

