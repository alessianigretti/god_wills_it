using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueOrigins : MonoBehaviour
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

    public GameObject firstDialogue;
    public GameObject dialogue;

 
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
      if(currentLine == 0 || currentLine == 4 || currentLine == 5 || currentLine == 6 || currentLine == 9)
		{
			blueText.enabled = true;
			greenText.enabled = false;
			blueText.text = textLines[currentLine];
		} else if(currentLine == 1 || currentLine == 2 || currentLine == 3 || currentLine == 7 || currentLine == 8)
		{
			greenText.enabled = true;
			blueText.enabled = false;
			greenText.text = textLines[currentLine];
		}

      if(currentLine == 9)
		{
			shrineTrigger.SetActive(true);
            cameraShrineTrigger.SetActive(true);
            firstDialogue.SetActive(false);
            dialogue.SetActive(false);
		}

      if(Input.GetKeyDown(KeyCode.E))
		{
			currentLine++;
      }

		if(currentLine > endAtLine)
		{
			textBox.SetActive(false);
		}
	}
}
