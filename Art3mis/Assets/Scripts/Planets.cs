using UnityEngine;

public class Planets : MonoBehaviour
{
    public float x = 1;
    public float y = 1;
    public float z = 1;

    void Update()
    {
        transform.Rotate(new Vector3(x, y, z) * Time.deltaTime);
    }
}
