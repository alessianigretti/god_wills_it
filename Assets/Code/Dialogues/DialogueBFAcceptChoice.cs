using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueBFAcceptChoice : MonoBehaviour
{
  public GameObject textBox;

  public Text greenText;

  public TextAsset textFile;
  public string[] textLines;

  public int currentLine;
  public int endAtLine;

  public GameObject player;

  public GameObject fadeTrigger;

  public Image blackScreen;
  public GameObject dramaAudio;

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
     
      if(currentLine == 121) //119-127
        {
          fadeTrigger.SetActive(true);
        }

      if(Input.GetKeyDown(KeyCode.E) && currentLine != endAtLine)
        {
          currentLine++;
      } else if(Input.GetKeyDown(KeyCode.E) && currentLine == endAtLine)
        {

        }

      if(currentLine > endAtLine)
        {
          textBox.SetActive(false);
        }
    }

  void BlackScreen()
    {
      blackScreen.enabled = true;
      blackScreen.rectTransform.localScale = new Vector2(Screen.width, Screen.height);
    }
}
