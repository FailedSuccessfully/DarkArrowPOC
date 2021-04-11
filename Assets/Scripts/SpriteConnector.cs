using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteConnector : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D myrb;
    // Update is called once per frame
    void Update()
    {
        transform.position = myrb.position;
    }
}
