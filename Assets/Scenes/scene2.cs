using UnityEngine;
using UnityEngine.UIElements;

public class scene2 : MonoBehaviour
{
    public float step;
    public float scaler = 1f;
    private Vector3 start;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            scaler += step;
            transform.position = start * scaler;

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            scaler -= step;
            transform.position = start * scaler;

        }

    }

}
