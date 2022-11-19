using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgScroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-2 * Time.deltaTime, 0);

        if (transform.position.x < -19.2)
        {
            transform.position = new Vector3(0f, transform.position.y);
        }
    }
}
