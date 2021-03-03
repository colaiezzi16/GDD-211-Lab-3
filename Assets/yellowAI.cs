using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowAI : AIparent
{
    void Awake()
    {
        base.SetParams("yellowShip", 4);
    }
}
