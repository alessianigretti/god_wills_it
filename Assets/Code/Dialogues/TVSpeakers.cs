using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TVSpeakers : MonoBehaviour
{
  public GameObject textBox;

  public Text whiteText;

  public TextAsset textFile;
  public string[] textLines;

  public int currentLine;
  public int endAtLine;

  public GameObject player;

  public GameObject boyTrigger;
  public GameObject tvSpeakers;
  public GameObject approachTrigger;

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
      whiteText.enabled = true;
      whiteText.text = textLines[currentLine];

      if(currentLine == 48)
        {
          boyTrigger.SetActive(true);
          whiteText.enabled = false;
          tvSpeakers.SetActive(false);
        }

      if(Input.GetKeyDown(KeyCode.E) && approachTrigger.activeSelf && currentLine != endAtLine)
        {
          currentLine++;
        }

      if(currentLine > endAtLine)
        {
          textBox.SetActive(false);
        }
    }
}