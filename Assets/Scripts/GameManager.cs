using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ballPrefab;
    private float x;
    private float y = 13.42f;
    private float z = 40.72f;

    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(-14f, 14f);
        Instantiate(ballPrefab, new Vector3(x, y, z), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
