using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Correction : MonoBehaviour
{
    private Transform tfm;
    private bool haveDone = false;
    // Start is called before the first frame update
    void Start()
    {
        tfm = FindObjectOfType<Player>().GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!haveDone)
        {
            tfm.position = new Vector3(tfm.position.x, MainManager.Instance.yVal, tfm.position.z);
            haveDone = true;
        }
    }
}
