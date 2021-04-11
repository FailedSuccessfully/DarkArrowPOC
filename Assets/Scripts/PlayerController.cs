using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveForce, jumpForce;
    private StateBase state;

    // Start is called before the first frame update
    void Start()
    {
        state = new StateBase(GetComponentInChildren<Rigidbody2D>(), moveForce, jumpForce);
    }

    // Update is called once per frame
    void Update()
    {
        state.GetInput();
    }
}
