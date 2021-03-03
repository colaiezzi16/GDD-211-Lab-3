using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redAI : AIparent
{
    // Start is called before the first frame update
    void Awake()
    {
        base.SetParams("redShip", 2);
    }
}
