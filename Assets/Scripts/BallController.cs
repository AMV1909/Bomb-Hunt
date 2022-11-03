using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private float x;
    private float y = 13.42f;
    private float z = 40.72f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {
        Destroy(gameObject);
        x = Random.Range(-14f, 14f);
        Instantiate(gameObject, new Vector3(x, y, z), Quaternion.identity);
    }
}
