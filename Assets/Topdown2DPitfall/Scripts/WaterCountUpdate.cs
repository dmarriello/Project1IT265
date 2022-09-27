using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterCountUpdate : MonoBehaviour
{
    private Player gamePlayer;

    // Start is called before the first frame update
    void Start()
    {
        gamePlayer = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Water Hazard Count: "+gamePlayer.fallCount.ToString();
    }
}
