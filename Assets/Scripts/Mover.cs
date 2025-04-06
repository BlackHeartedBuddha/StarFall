using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;
    [SerializeField] float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInfo();
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // if (transform.position.x > 10f || transform.position.x < -10f || transform.position.y > 10f || transform.position.y < -10f || transform.position.z > 10f || transform.position.z < -10f)
        // {
        //     transform.position = new Vector3(0, 0, 0);
        // }

        PrintState();
        float xValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(xValue, 0, zValue);
    }

    void PrintState()
    {
        Debug.Log($"Object Position: {transform.position}");
        Debug.Log($"Object Speed: {speed}");
    }

    void PrintInfo()
    {
        Debug.Log("Hello World!");
        Debug.Log("use Arrow keys to move the object");
    }
}
