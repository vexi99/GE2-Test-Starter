using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NematodeSchool : MonoBehaviour
{
    //NematodeSchool class used to spawn multiple Nematode from Nematode Class.
    //Create spawning features in Nematode.cs and then complete in here.

    public GameObject prefab;
    public Nematode nematode; 

    [Range (1, 5000)]
    public int radius = 50;
    
    public int count;

    // Start is called before the first frame update
    void Awake()
    {
        Nematode nematode = new Nematode();
        // Put your code here
        count = Random.Range(1,10);
        nematode.CreateNematode();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
