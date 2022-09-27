using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    private bool inText = false;
    private bool seenDialogue1 = false;
    int textID=-1;
    private Player gamePlayer;
    private GameObject dialogue1;
    // Start is called before the first frame update
    void Start()
    {
        gamePlayer = FindObjectOfType<Player>();
        dialogue1 = GameObject.Find("CongratsText");
    }

    // Update is called once per frame
    void Update()
    {
        if(gamePlayer.GetComponent<Transform>().position.x>6.0 && gamePlayer.GetComponent<Transform>().position.x < 6.5 && !seenDialogue1)
        {
            inText = true;
            gamePlayer.isMovable = false;
            seenDialogue1 = true;
            dialogue1.GetComponent<RectTransform>().position = new Vector3(dialogue1.GetComponent<RectTransform>().position.x, dialogue1.GetComponent<RectTransform>().position.y-2000);
            textID = 1;
        }
        if(inText)
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                inText = false;
                gamePlayer.isMovable = true;
                switch(textID)
                {
                    case 1:
                        dialogue1.GetComponent<RectTransform>().position = new Vector3(dialogue1.GetComponent<RectTransform>().position.x, dialogue1.GetComponent<RectTransform>().position.y + 2000);
                        break;
                    default:
                        Debug.Log("You're closing out of text that doesn't exist. (This shouldn't appear unless the dialogue system breaks spectacularly.)");
                        break;
                }
            }
        }
    }
}
