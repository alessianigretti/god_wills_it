using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueLoveConformChoice : MonoBehaviour
{
  public GameObject textBox;

  public Text greenText;

  public TextAsset textFile;
  public string[] textLines;

  public int currentLine;
  public int endAtLine;

  public GameObject player;

  public GameObject fadeTrigger;

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
      greenText.enabled = true;
      greenText.text = textLines[currentLine];

      if(Input.GetKeyDown(KeyCode.E) && currentLine != endAtLine)
        {
          currentLine++;
      } else if(Input.GetKeyDown(KeyCode.E) && currentLine == endAtLine)
        {
          fadeTrigger.SetActive(true);
        }

      if(currentLine > endAtLine)
        {
          textBox.SetActive(false);
        }
    }
}