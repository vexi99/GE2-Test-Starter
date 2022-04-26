using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length; //To Be Set Random in Awake() function

    public Material material;
    public GameObject head;

    void Awake()
    {
        // Put your code here!
        length = Random.Range(3,15);

        CreateNematode();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateNematode()
    {
        //For loop of random length deciding how many spheres are created for Nematode Body Length
        for(int i = 0; i < length; i++)
        {
            GameObject body = GameObject.Instantiate<GameObject>(head);

            body.transform.position = transform.TransformPoint(new Vector3(0,0,i));
            body.transform.parent = body.transform;
        }   
    }
}
