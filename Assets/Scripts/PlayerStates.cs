using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Committing Class STUB
public interface InputReciever
{
    public void GetInput();
}

public class StateBase : InputReciever
{
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
        if (Input.GetButton("Jump")){
            InputJump();
        }
        if (Input.GetButton("Fire1")){
            InputShoot();
        }
        if (Input.GetButton("Fire2")){
            InputDash();
        }
    }

    protected virtual void InputHorizontal(float dir){
        
    }
    protected virtual void InputVertical(float dir){
        
    }
    protected virtual void InputJump(){
        
    }
    protected virtual void InputShoot(){
        
    }
    protected virtual void InputDash(){
        
    }
}

public class PlayerStateGrounded : StateBase 
{
}
public class PlayerStateAirborne : StateBase 
{
}

public class BowStateDraw : StateBase
{
}
public class BowStateRelease : StateBase
{
}