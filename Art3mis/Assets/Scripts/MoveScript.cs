using UnityEngine;

public class MoveScript : MonoBehaviour
{
    float animationTime;

    void Start()
    {
        animationTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        animationTime += Time.deltaTime;

        //stellarJump(Vector3.right, 5, 9);
        lostInSpace(Vector3.right);
    }

    private void stellarJump(Vector3 direction, float moveTime, float jump)
    {

        if (animationTime <= moveTime)
        {
            transform.Translate(direction * Time.deltaTime, Space.World);
        }
        else if (animationTime > moveTime && animationTime < jump)
        {
            transform.Translate(direction * Time.deltaTime / 2, Space.World);
        }
        else
        {
            transform.Translate(direction * Time.deltaTime * 50, Space.World);
        }
    }

    private void lostInSpace(Vector3 direction)
    {
        transform.Translate(direction * Time.deltaTime, Space.World);
        transform.Rotate(new Vector3(45, 35, 55) * Time.deltaTime / 3);
    }

}
