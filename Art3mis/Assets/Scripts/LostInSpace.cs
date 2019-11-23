using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostInSpace : MonoBehaviour
{
    // Receberá o planepa para onde a nave será direcionada
    public GameObject planet;
    private Vector3 planetPosition;

    void Start()
    {
        if (planet == null)
        {
            planetPosition = Vector3.right;
        }
        else
        {
            planetPosition = planet.transform.position.normalized;
        }

    }
    void Update()
    {   
        lostInSpace(planetPosition);
    }

    private void lostInSpace(Vector3 direction)
    {
        transform.Translate(direction * Time.deltaTime, Space.World);
        transform.Rotate(new Vector3(45, 35, 55) * Time.deltaTime / 3);
    }
}
