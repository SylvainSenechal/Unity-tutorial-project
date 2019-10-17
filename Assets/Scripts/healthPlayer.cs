// tuto : https://codingchronicles.com/unity-vr-development/day-19-creating-player-health-system-health-ui-unity
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class healthPlayer : MonoBehaviour {
  public Slider healthBar;
  public GameObject textPlayAgain;
  public GameObject textWP;
  public GameObject buttonPlayAgain;
  public GameObject buttonStop;
  public GameObject buttonLeaveAfterWin;

  public float health = 50;
  public float lastHealth = 2f;

  void Start() {
    buttonPlayAgain.gameObject.SetActive(false);
    textPlayAgain.gameObject.SetActive(false);
    textWP.gameObject.SetActive(false);
    buttonStop.gameObject.SetActive(false);
    buttonLeaveAfterWin.gameObject.SetActive(false);
  }
  void Update() {
    // if (this.health <= 0) { todo
    //   Destroy(this.gameObject);
    // }
    lastHealth += Time.deltaTime;
    gameObject.transform.GetChild(2).GetComponent<Renderer>().material.color = Color.Lerp(Color.green, Color.white, lastHealth/2f);
    GetComponent<Renderer>().material.color = Color.Lerp(Color.green, Color.white, lastHealth);
  }
  public void takeDamage(float dmg) {
    health -= dmg;
    healthBar.value = health;
    if (health <= 0) {
      textPlayAgain.gameObject.SetActive(true);
      buttonPlayAgain.gameObject.SetActive(true);
      buttonStop.gameObject.SetActive(true);
    }
  }

  public void gameWon() {
    textWP.gameObject.SetActive(true);
    buttonLeaveAfterWin.gameObject.SetActive(true);
  }
  public void gainHeal(float hp) {
    lastHealth = 0;
    health += hp;
    healthBar.value = health;
  }
}
