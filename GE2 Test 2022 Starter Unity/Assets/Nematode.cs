using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length; //To Be Set Random in Awake() function
    public int startXPos, startYPos; //Starting X and Y Coords

    public Material material;
    public GameObject head;
    public GameObject[] body;

    void Awake()
    {
        // Put your code here!
        length = Random.Range(3,15);

        body = new GameObject[length];

        CreateNematode();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NematodeMovement();   
    }

    void NematodeMovement()
    {
        Vector3 change = new Vector3(0.005f,0,0); 
        for(int i = 0; i < length; i++)
        {
            body[i].transform.position += change; //increasing x pos slowly
        }
    }

    void CreateNematode()
    {
        //Create Random starting Position
        startXPos = Random.Range(-100,100);
        startYPos = Random.Range(-100,100);

        

        //For loop of random length deciding how many spheres are created for Nematode Body Length
        for(int i = 0; i < length; i++)
        {

            body[i] = GameObject.Instantiate<GameObject>(head);

            body[i].transform.position = transform.TransformPoint(new Vector3(startXPos,startYPos,i)); //spawn 1 unit away from last
            //body[i].transform.parent = transform; //trying to set body component as a child

            //changing with of nematode as it lengthens
            if(i < length/2)
            {
                //making skinnier
                float width = (1.0f / (length / 2) * i);
                body[i].transform.localScale = new Vector3(width, width, body[i].transform.localScale.z);
            }
            else
            {
                //making wider
                float width = (1.0f * (length / 2) / i);
                body[i].transform.localScale = new Vector3(width, width, body[i].transform.localScale.z);
            }
            
        }   
    }
}
