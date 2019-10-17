using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthEnnemi : MonoBehaviour {
  public float health = 10;
  public float lastTimeDmg = 0f;

  void Update() {
    if (this.health <= 0) {
      Destroy(this.gameObject);
    }
    lastTimeDmg += Time.deltaTime;
    GetComponent<Renderer>().material.color = Color.Lerp(Color.red, Color.white, lastTimeDmg);
  }
  public void takeDamage(float dmg) {
    lastTimeDmg = 0;
    health -= dmg;
    // healthBar.value = health;
  }
}
