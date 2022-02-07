using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{ 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // playerを前に進ませる
        this.transform.Translate(this.transform.forward * Time.deltaTime);





        this.transform.Rotate(0, 0, 0);

        // Objectを左右に動かす
        float dx = Input.GetAxis("Horizontal");

        transform.position = new Vector3 
            (transform.position.x + dx, 1f, 3f);



    }


    
}
