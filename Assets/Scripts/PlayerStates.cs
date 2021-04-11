using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Committing Class STUB
public interface iInputReciever
{
    public void GetInput();
}

public class StateBase : iInputReciever
{
    private Rigidbody2D myRigidbody;
    private float moveF, jumpF;
    
    public StateBase (Rigidbody2D myRigidbody, float moveF, float jumpF){
        this.myRigidbody = myRigidbody;
        this.moveF = moveF;
        this.jumpF = jumpF;
    }

    public void GetInput(){
        // Handle Input
        float horz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        if (horz != 0){
            InputHorizontal(horz);
        }
        if (vert != 0){
            InputVertical(vert);
        }
        if (Input.GetButtonDown("Jump")){
            InputJump();
        }
        if (Input.GetButtonDown("Fire1")){
            InputShoot();
        }
        if (Input.GetButtonDown("Fire2")){
            InputDash();
        }
    }

    protected virtual void InputHorizontal(float dir){
        myRigidbody.AddForce(new Vector2(dir * Time.deltaTime * moveF, 0f));
    }
    protected virtual void InputVertical(float dir){
        
    }
    protected virtual void InputJump(){
        myRigidbody.AddForce(new Vector2(0f, jumpF));
    }
    protected virtual void InputShoot(){
        
    }
    protected virtual void InputDash(){
        
    }
}

public class PlayerStateGrounded : StateBase
{
    public PlayerStateGrounded(Rigidbody2D myRigidbody, float moveF, float jumpF) : base(myRigidbody, moveF, jumpF)
    {
    }
}
public class PlayerStateAirborne : StateBase
{
    public PlayerStateAirborne(Rigidbody2D myRigidbody, float moveF, float jumpF) : base(myRigidbody, moveF, jumpF)
    {
    }
}

public class BowStateDraw : StateBase
{
    public BowStateDraw(Rigidbody2D myRigidbody, float moveF, float jumpF) : base(myRigidbody, moveF, jumpF)
    {
    }
}
public class BowStateRelease : StateBase
{
    public BowStateRelease(Rigidbody2D myRigidbody, float moveF, float jumpF) : base(myRigidbody, moveF, jumpF)
    {
    }
}