using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreenScript : MonoBehaviour
{
    private Transform tfm;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        tfm = GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(MainManager.Instance.paused)
        {
            tfm.position = new Vector3(tfm.position.x, tfm.position.y, -3);
            sr.sortingOrder = 5;
        }
        else
        {
            tfm.position = new Vector3(tfm.position.x, tfm.position.y, 20);
            sr.sortingOrder = 0;
        }
    }
}
