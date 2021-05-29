using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Myplayer : MonoBehaviour
{

    Vector2 move=Vector2.zero;
    float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        var keyboard = Keyboard.current;
        var mouse = Mouse.current;
        //lee la posicion actual del mouse en el eje x
         var moveMouse = mouse.position.x.ReadValue();
        

        if (keyboard==null)
        return;


        // if (keyboard.rightArrowKey.isPressed){
            
        //     move.x += speed*Time.deltaTime;

        //     this.transform.position = move;
        // }
        
        //Lee si se esta presionando la tecla fecla derecha
        var pressRightArrow= keyboard.rightArrowKey.ReadValue();
        //Lee si se esta presionando la tecla fecla Izquierda
        var pressLeftArrow=keyboard.leftArrowKey.ReadValue();
        //Multiplica el valor de presion por el de velocidad y lo estabiliza a todos los cuadros
        move.x += pressRightArrow *speed *Time.deltaTime;
        move.x -= pressLeftArrow*speed*Time.deltaTime;

    //Inicia transformacion de objeto sobre eje X
     this.transform.position= move;

     this.transform.localEulerAngles = new Vector3(0,moveMouse,0);

    }
}
