using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour {
  public void leaveGame() {
    Debug.Log("quit");
    Application.Quit();
  }
}
