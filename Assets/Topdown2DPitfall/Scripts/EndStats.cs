using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndStats : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Water Hazard Count: " + MainManager.Instance.waterCount.ToString() + "\nTime Spent on Title Screen: " + MainManager.Instance.TimeOnTitle + "\nTime Spent in Room 1: " + MainManager.Instance.TimeInRoom1 + "\nTime Spent in Room 2: " + MainManager.Instance.TimeInRoom2 + "\n\nPress any key to quit.";
        if (Input.anyKey)
        {
            Application.Quit();
        }
    }
}
