using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class scene1part1 : MonoBehaviour
{
    public float amplitude;
    public float frequincy;
    public string whichoneisit;

    private Vector3 start;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Mathf.Sin(Time.time * frequincy) * amplitude;
        if(whichoneisit == "x")
        {
            transform.position = start + new Vector3(offset, 0, 0);
        }
        if(whichoneisit == "y")
        {
            transform.position = start + new Vector3(0, offset, 0);
        }
        if(whichoneisit == "z")
        {
            transform.position = start + new Vector3(0, 0, offset);
        }
    }
}
