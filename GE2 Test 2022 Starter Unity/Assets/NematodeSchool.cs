using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NematodeSchool : MonoBehaviour
{
    //NematodeSchool class used to spawn multiple Nematode from Nematode Class.
    //Create spawning features in Nematode.cs and then complete in here.

    public GameObject prefab;
    //public 

    [Range (1, 5000)]
    public int radius = 50;
    
    public int count = 10;

    // Start is called before the first frame update
    void Awake()
    {
        // Put your code here
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
