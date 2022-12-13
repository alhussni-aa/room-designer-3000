using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject scrollx;
    public GameObject scrolly;
    private Vector3 start;

    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {    
        float xbar = scrollx.GetComponent<Scrollbar>().value;
        float ybar = scrolly.GetComponent<Scrollbar>().value;
        float x = 4 * (2 * xbar - 1);
        float y = 4 * (2 * ybar - 1);
        transform.position = start + new Vector3(x, 0, y);
    }
}