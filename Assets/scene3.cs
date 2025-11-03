using UnityEngine;
using UnityEngine.UIElements;

public class scene3 : MonoBehaviour
{
    public float currentz;
    private Vector3 start;
    public GameObject child;
    public GameObject enemy;
    private Vector3 enemydir;
    public float dotproduct;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        start = transform.position;
        child.transform.position = transform.position + -transform.forward;
        
    }

    // Update is called once per frame
    void Update()
    {
        enemydir = (enemy.transform.position - transform.position).normalized;

        if (Input.GetKeyDown(KeyCode.W))
        {
            currentz += 1;
            transform.position = new Vector3(0, 0, currentz);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            currentz -= 1;
            transform.position = new Vector3(0, 0, currentz);
        }

        dotproduct = Vector3.Dot(transform.forward, enemydir);
    }

}
