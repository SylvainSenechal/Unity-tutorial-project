using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBullet : MonoBehaviour {
  public float moveSpeed = 6f;

  void Update() {
    this.transform.position += this.transform.forward * moveSpeed * Time.deltaTime;
  }

  void OnTriggerEnter(Collider other) {
    if (other.gameObject.CompareTag("ennemi")) {
      // Destroy(other.gameObject);
      other.GetComponent<healthEnnemi>().takeDamage(5);
    }
    if (other.gameObject.CompareTag("boss")) {
      // Destroy(other.gameObject);
      other.GetComponent<healthBoss>().takeDamage(5);
    }
    Destroy(this.gameObject);
  }
}
