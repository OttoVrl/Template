using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : SingletonDestroyMono<DataManager>
{
    private int level;
    private float money;

    public int Level
    {
        get
        {
            return level;
        }
        set
        {
            level = value;
        }
    }
    public float Money
    {
        get
        {
            return money;
        }
        set
        {
            money = value;
        }
    }


}
