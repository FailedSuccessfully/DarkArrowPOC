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
    }

    protected virtual void InputHorizontal(bool isRight){
        
    }
    protected virtual void InputVertical(bool isUp){
        
    }
    protected virtual void InputActionA(){
        
    }
    protected virtual void InputActionB(){
        
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