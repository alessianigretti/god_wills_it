using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{
	public GameObject dialogueOrigins;
	public GameObject dialogueOriginsShrine;

	private bool collisionBooks;
	public GameObject popUp;
	public GameObject holyBook;
	public GameObject scienceBook;
	public GameObject hoveringHolyBook;
	public GameObject hoveringScienceBook;
	private bool hasHolyBook;
	private bool hasScienceBook;

	private bool collisionSceneOne;
	public GameObject popUpSceneOne;

	private bool collisionShrine;
	public GameObject popUpShrine;
	public GameObject shrineTrigger;
    public GameObject bookshelfTrigger;

    public GameObject holyDialogueOriginsBookChoice;
    public GameObject scienceDialogueOriginsBookChoice;

    public GameObject firstDialogue;

	void Start()
	{
		popUp.SetActive(false);
		collisionBooks = false;
		holyBook.SetActive(true);
		scienceBook.SetActive(true);
		hoveringHolyBook.SetActive(false);
		hoveringScienceBook.SetActive(false);
		hasHolyBook = false;
		hasScienceBook = false;

		collisionSceneOne = false;
		popUpSceneOne.SetActive(false);

		collisionShrine = false;
	}

	void Update()
	{
		if(collisionBooks && bookshelfTrigger.activeSelf)
		{
			Debug.Log("collision");
			if(Input.GetKeyDown(KeyCode.X) && !hasHolyBook && !hasScienceBook)
			{
				holyBook.SetActive(false);
				hoveringHolyBook.SetActive(true);
				hasHolyBook = true;
			} else if(Input.GetKeyDown(KeyCode.X) && hasHolyBook && !hasScienceBook)
			{
				holyBook.SetActive(true);
				hoveringHolyBook.SetActive(false);
				hasHolyBook = false;
			} else if(Input.GetKeyDown(KeyCode.X) && !hasHolyBook && hasScienceBook)
			{
				scienceBook.SetActive(true);
				hoveringScienceBook.SetActive(false);
				hasScienceBook = false;
				holyBook.SetActive(false);
				hoveringHolyBook.SetActive(true);
				hasHolyBook = true;
			}

			if(Input.GetKeyDown(KeyCode.C) && !hasHolyBook && !hasScienceBook)
			{
				scienceBook.SetActive(false);
				hoveringScienceBook.SetActive(true);
				hasScienceBook = true;
			} else if(Input.GetKeyDown(KeyCode.C) && !hasHolyBook && hasScienceBook)
			{
				scienceBook.SetActive(true);
				hoveringScienceBook.SetActive(false);
				hasScienceBook = false;
			} else if(Input.GetKeyDown(KeyCode.C) && hasHolyBook && !hasScienceBook)
			{
				holyBook.SetActive(true);
				hoveringHolyBook.SetActive(false);
				hasHolyBook = false;
				scienceBook.SetActive(false);
				hoveringScienceBook.SetActive(true);
				hasScienceBook = true;
			}
		}

		if(collisionSceneOne && firstDialogue.activeSelf)
		{
			if(Input.GetKeyDown(KeyCode.E))
			{
				dialogueOrigins.SetActive(true);
			}
		} else {
			dialogueOrigins.SetActive(false);
		}

		if(collisionShrine && shrineTrigger.activeSelf)
		{
			if(Input.GetKeyDown(KeyCode.E))
			{
				dialogueOriginsShrine.SetActive(true);
			}
		} else {
			dialogueOriginsShrine.SetActive(false);
		}

      if(collisionSceneOne && hasHolyBook && Input.GetKeyDown(KeyCode.E))
        {
          holyDialogueOriginsBookChoice.SetActive(true);
        }
        /*} else {
          holyDialogueOriginsBookChoice.SetActive(false);
        }*/
      if(collisionSceneOne && hasScienceBook && Input.GetKeyDown(KeyCode.E))
        {
          scienceDialogueOriginsBookChoice.SetActive(true);
        }
        /*} else {
          scienceDialogueOriginsBookChoice.SetActive(false);
            }*/
     }
	

	void OnTriggerEnter(Collider coll)
	{
		if(coll.tag == "Books")
		{
			collisionBooks = true;
          if(bookshelfTrigger.activeSelf)
            {
              popUp.SetActive(true);
            } else {
              popUp.SetActive(false);
            }
		}

		if(coll.tag == "SonSatDown")
		{
			collisionSceneOne = true;
            
          if((firstDialogue.activeSelf) || (bookshelfTrigger.activeSelf && (hasScienceBook || hasHolyBook)))
            {
              popUpSceneOne.SetActive(true);
            }
		}

		if(coll.tag == "Shrine")
		{
			collisionShrine = true;
			if(shrineTrigger.activeSelf)
			{
				popUpShrine.SetActive(true);
            } else {
                popUpShrine.SetActive(false);
            }
		}
	}

	void OnTriggerExit(Collider coll)
	{
		if(coll.tag == "Books")
		{
			collisionBooks = false;
			popUp.SetActive(false);
		}

		if(coll.tag == "SonSatDown")
		{
			collisionSceneOne = false;
			popUpSceneOne.SetActive(false);
		}

		if(coll.tag == "Shrine")
		{
			collisionShrine = false;
			popUpShrine.SetActive(false);
		}
	}
}