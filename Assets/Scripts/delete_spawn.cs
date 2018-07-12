using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete_spawn : MonoBehaviour {

    public float lifetime = 10f;

	void Update () {

		if(lifetime > 0) {
            lifetime -= Time.deltaTime;
            if (lifetime <= 0) {
                Destruction();
            }
        }

        if (this.transform.position.y < -1)
        {
            transform.Translate(0,0,0);
        }
        //min y
        if (this.transform.position.y <= -20){
            Destruction();
        }
        //min x
        if (this.transform.position.x <= -46){
            Destruction();
        } 
        //min z
        if (this.transform.position.z <= -60){
            Destruction();
        }
        //max x
        if (this.transform.position.x >= 80){
            Destruction();
        }
        //max z
        if (this.transform.position.z >= 36){
            Destruction();
        } 

       // if (this.transform.position.y <= -20){
      //      Destruction();
      //  }
	}

    void OnCollisionEnter(Collision coll) { 
        if(coll.gameObject.name == "despawner"){
            Destruction();
        }
    }

    void Destruction() {
        Destroy(this.gameObject);
    }
}
