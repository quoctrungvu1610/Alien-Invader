using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormRotate : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateBossWorm();
    }
    void RotateBossWorm()
    {
        Vector3 eulerVector = new Vector3(0, 0, 1);
        transform.Rotate(eulerVector * rotateSpeed);
    }
}
