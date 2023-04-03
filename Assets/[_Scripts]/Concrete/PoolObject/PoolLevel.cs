using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolLevel : MonoBehaviour
{
    public void Deactiavte(){
        gameObject.SetActive(false);
    }
    public void Activate(){
        gameObject.SetActive(true);
    }
}