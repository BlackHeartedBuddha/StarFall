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
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // if (transform.position.x > 10f || transform.position.x < -10f || transform.position.y > 10f || transform.position.y < -10f || transform.position.z > 10f || transform.position.z < -10f)
        // {
        //     transform.position = new Vector3(0, 0, 0);
        // }

        float xValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(xValue, 0, zValue);
    }
}
