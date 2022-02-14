using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{ 
    [SerializeField]
    private float speed = 1;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = this.transform.forward;

        //入力を受け付ける
        //Objectを左右に動かす
        float dx = Input.GetAxis("Horizontal");

        direction += this.transform.right * dx * speed;

        //playerを前に進ませる　さらに左右方向の入力に対応した移動を行う
        this.transform.Translate(direction * Time.deltaTime);

    }


    
}
