using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Will_spawn_at_start : MonoBehaviour
{
    public GameObject Prefab;
    void Start()
    {
        if(Prefab != null )
        {
            Instantiate(Prefab, transform.position, transform.rotation);
        }
    }

}
