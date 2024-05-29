using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
    public bool doorIsOpen = false;
    public Transform door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doorIsOpen){
            door.rotation = Quaternion.Euler( 0, 90, 0 );
        }
        else {
            door.rotation = Quaternion.Euler( 0, 0, 0 );
        }
    }
}
