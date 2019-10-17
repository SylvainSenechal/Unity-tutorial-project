using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class healthBoss : MonoBehaviour {
  public Slider healthBar;
  public float health = 30;
  public float lastTimeDmg = 2f;

  void Update() {
    if (this.health <= 0) {
      Destroy(this.gameObject);
      GameObject.Find("personnage").GetComponent<healthPlayer>().gameWon();
    }
    lastTimeDmg += Time.deltaTime;
    GetComponent<Renderer>().material.color = Color.Lerp(Color.red, Color.white, lastTimeDmg);
  }
  public void takeDamage(float dmg) {
    lastTimeDmg = 0;
    health -= dmg;
    healthBar.value = health;
  }
}
