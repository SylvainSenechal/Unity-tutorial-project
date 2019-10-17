using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacementEnnemi2 : MonoBehaviour {
  public float moveSpeed = 1f;
  public string direction = "droite";
  public float timeChangeDirection;


  void Update() {

    timeChangeDirection += Time.deltaTime;
    if (timeChangeDirection > 3) {
      timeChangeDirection = 0;
      if (direction == "droite") direction = "gauche";
      else direction = "droite";
    }


    if (direction == "droite") {
      transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
    if (direction == "gauche") {
      transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
    }
  }
}
