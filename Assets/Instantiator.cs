using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject myCubePrefab;
    public int cloneAmount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < cloneAmount; i++)
            {
                GameObject clon;
                clon = Instantiate(myCubePrefab);
                Destroy(clon, 1);
            }
        }
    }
}
