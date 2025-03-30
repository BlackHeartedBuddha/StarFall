using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 5f);
        if (transform.position.x > 10f || transform.position.x < -10f || transform.position.y > 10f || transform.position.y < -10f || transform.position.z > 10f || transform.position.z < -10f)
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
