using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToRoom2 : MonoBehaviour
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
        if(gamePlayer.GetComponent<Transform>().position.x>8.3)
        {
            MainManager.Instance.yVal = gamePlayer.GetComponent<Transform>().position.y;
            SceneManager.LoadScene(2);
        }
    }
}
