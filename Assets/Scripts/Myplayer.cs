using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Myplayer : MonoBehaviour
{

    Vector2 move=Vector2.zero;

    float speed = 2f;

    public void inputmove(InputAction.CallbackContext context){

        move =context.ReadValue<Vector2>();

    }





    // Start is called before the first frame update
    void Start()
    {
       
    }

    

    void Update(){
       
    Vector2 onmove = Vector2.zero;    
         
        
 onmove.x += move.x * speed *Time.deltaTime;
        

    this.transform.position= move;
    

    }
}
