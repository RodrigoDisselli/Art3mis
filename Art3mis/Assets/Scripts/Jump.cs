using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private float animationTime;
    void Start()
    {
        animationTime = 0;
    }

    void Update()
    {
        animationTime += Time.deltaTime;

        stellarJump(Vector3.right, 7, 13);
    }

    private void stellarJump(Vector3 direction, float moveTime, float jump)
    {

        if (animationTime <= moveTime)
        {
            transform.Translate(direction * Time.deltaTime*3, Space.World);
        }
        else if (animationTime > moveTime && animationTime < jump)
        {
            transform.Translate(direction * Time.deltaTime / 2, Space.World);
        }
        else
        {
            transform.Translate(direction * Time.deltaTime * 300, Space.World);
        }
    }
}
