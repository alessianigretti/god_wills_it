using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueOriginsShrine : MonoBehaviour
{
	public GameObject textBox;

	public Text goldText;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;

	public GameObject player;

	public GameObject shrineTrigger;
    public GameObject bookshelfTrigger;
    public GameObject activeFocus;

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
		goldText.text = textLines[currentLine];

		if(currentLine == 17)
		{
          activeFocus.SetActive(false);
          bookshelfTrigger.SetActive(true);
          shrineTrigger.SetActive(false);
        }

      if(Input.GetKeyDown(KeyCode.E) && currentLine != 17)
		{
			currentLine++;
		}

		if(currentLine > endAtLine)
		{
			textBox.SetActive(false);
		}
	}
}