using UnityEngine;

public class scene1part2 : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;
    private Vector3 cube1pos;
    private Vector3 cube2pos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cube1pos = cube1.transform.position;
        cube2pos = cube2.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        cube1pos = cube1.transform.position;
        cube2pos = cube2.transform.position;
        transform.position = cube1pos + cube2pos;

    }
}
