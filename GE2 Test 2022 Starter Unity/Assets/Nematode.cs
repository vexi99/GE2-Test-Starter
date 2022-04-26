using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length; //To Be Set Random

    public Material material;
    public GameObject head;

    void Awake()
    {
        // Put your code here!
    }


    // Start is called before the first frame update
    void Start()
    {
        length = Random.Range(0,20); //random length between 0 and 20
        CreateNematode();
    }

    // Update is called once per frame
    void Update()
    {
        head.transform.position += new Vector3(0, 10, 0);
    }

    void CreateNematode()
    {
        Vector3 test = new Vector3(0, 0, 0);
        Instantiate(head, test,Quaternion.identity);
        head.transform.position = new Vector3(0, 10, 0);
    }
}
