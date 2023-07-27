using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject prefab;
    private void Start()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
