using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 3f;

    void Update()
    {
        if (transform.position.y < -6.5f)
            Destroy(gameObject);
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);    
    }
}
