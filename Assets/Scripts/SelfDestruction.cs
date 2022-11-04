using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruction : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float timeToDestruct = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject,timeToDestruct);
    }
}
