using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
  public GameObject bulletPrefab;


  void Update() {
    if (Input.GetMouseButtonDown(0)) {
      // this.GetComponent<healthPlayer>().takeDamage(10);

      Quaternion playerRotation = this.transform.rotation;
      // On créer une balle à la place du gameObject vide mis devant le bras (getChild(0))
      GameObject bullet = Instantiate<GameObject>(bulletPrefab, this.gameObject.transform.GetChild(0).transform.position, playerRotation) as GameObject;
    }
  }
}
