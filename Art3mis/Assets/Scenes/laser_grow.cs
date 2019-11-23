using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser_grow : MonoBehaviour
{
    public float speed = 5f;
    Vector3 temp;

    /*public bool switchValue = false;

    void upDownScale(bool switchValue)
    {
        if(switchValue == false)
        {
            temp = transform.localScale;
            temp.x += 500;

            transform.localScale = temp;

            switchValue = true;
        }
        if (switchValue == true)
        {
            temp = transform.localScale;
            temp.x -= 500;

            transform.localScale = temp;

            switchValue = false;
        }
    }

    float teste(bool switchValue)
    {

        if (switchValue == false)
        {
            switchValue = true;
            return 4f;
        }
        if (switchValue == true)
        {
            switchValue = false;
            return -4f;
        }

        return 0;
    }*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //time += Time.deltaTime;

        temp = transform.localScale;
        temp.x -= Time.deltaTime;

        transform.localScale = temp;

        
    }
}
